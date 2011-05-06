var gmap;
var station_infowindow;
var markerArray = [];

function go() {
    var initialLocation = new google.maps.LatLng(38.897307, -77.01436);
    var mapOptions = { zoom: 13, mapTypeId: google.maps.MapTypeId.ROADMAP };
    gmap = new google.maps.Map(document.getElementById("station_map"), mapOptions);
    gmap.setCenter(initialLocation);
    var bikeLayer = new google.maps.BicyclingLayer();
    bikeLayer.setMap(gmap);

    station_infowindow = new google.maps.InfoWindow({ size: new google.maps.Size(30, 50) });

    getData();
    setInterval('getData();', 60000);
}

function getData() {
    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: "m.asmx/get",
        success: function (data) {
            for (m in markerArray) {
                markerArray[m].setMap(null);
            }
            markerArray = new Array();

            for (s in data.d) {
                (function () {
                    var station = data.d[s];
                    var icon = "http://www.capitalbikeshare.com/stations/cb-map-icon.png";
                    if (station.installed == false) {
                        icon = "http://www.capitalbikeshare.com/stations/cb-map-icon-planned.png";
                    }
                    else if (station.locked) {
                        icon = "http://www.capitalbikeshare.com/stations/cb-map-icon-outofservice.png";
                    }

                    var marker = new google.maps.Marker({
                        position: new google.maps.LatLng(station.lat, station.lng),
                        map: gmap,
                        icon: icon,
                        title: station.name
                    });

                    google.maps.event.addListener(marker, "click", function () {
                        popData(station, marker);
                    });

                    markerArray.push(marker);
                })();
            }

            $.ajax({
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                url: "m.asmx/update"
            });
        }
    });
}

function popData(station, marker) {
    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: '{"id":"' + station.id + '"}',
        url: "m.asmx/historic",
        success: function (data) {
            var mapWindow = document.createElement("div");
            $(mapWindow).attr("id", "map_window");
            $(mapWindow).append('<span id="station_title">' + station.name + '</span><br/>' +
                '<strong>Bikes:</strong> ' + station.bikeCount + '<br/>' +
                '<strong>Docks:</strong> ' + station.dockCount);
            
            var fw = document.createElement("div");
            $(fw).attr("id", "flot_window");
            $(fw).css("height", 100);
            $(fw).css("width", 300);
            $(mapWindow).append(fw);

            var hoverData = document.createElement("span");
            $(hoverData).attr("id", "hoverData");
            $(mapWindow).append(hoverData);

            var c = [];
            for (r in data.d) {
                c.push([r, data.d[r].bikeCount]);
            }

            $("body").data("data", data.d);
            $("body").data("s", station);

            station_infowindow.setContent(mapWindow);
            station_infowindow.open(gmap, marker);

            $.plot($("#flot_window"), [c],
            {
                xaxis:
                {
                    ticks: [[0, "-24h"], [72, "-18h"], [144, "-12h"], [216, "-6h"]]
                },
                yaxis:
                {
                    tickDecimals: 0
                },
                grid: { hoverable: true }
            });

            $("#flot_window").bind("plothover", function (event, pos, item) {
                var xPoint = pos.x.toFixed(0);
                if ((xPoint >= 0) && (xPoint < c.length)) {
                    getHistoricForTime(xPoint);
                }
            });
        }
    });
}

function getHistoricForTime(xPoint) {
    var data = $("body").data("data");
    var s = $("body").data("s");
    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: '{"id":"' + s.id + '", "dt":"' + data[xPoint].date + '"}',
        url: "m.asmx/historicAll",
        success: function (data) {
            var hr = data.d;
            var rTotal = 0;
            for (r in hr.rList) {
                rTotal += hr.rList[r].bikeCount;
            }
            var rCount = (rTotal / hr.rList.length);
            $("#hoverData").text("Average " + (hr.isWeekend ? "weekend" : "weekday") + " bikes at " + hr.easyTime + ": " + rCount.toFixed(2));
        }
    });
} 