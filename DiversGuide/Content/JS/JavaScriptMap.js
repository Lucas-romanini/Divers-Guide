var map;
function initMap() {
    // Create the map with no initial style specified.
    // It therefore has default styling.
    
    var SpotType = [

    ]
    
        var slaebeSteder = [
            

    ]
    var Spot = [

    ]
    var spot = { lat: -25.363, lng: 131.044 };
    var spot2 = { lat: 56.13330691237569, lng: 10.755615234375 };
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 56.13330691237569, lng: 10.755615234375 },
        zoom: 9,
        scrollwheel: false,
        mapTypeControl: false,
        mapTypeId: 'roadmap'
    });
    var marker = new google.maps.Marker({
        position: spot,
        
        map: map
    });
    var marker = new google.maps.Marker({
        position: spot2,

        map: map
    });
    // Add a style-selector control to the map.
    var styleControl = document.getElementById('style-selector-control');
    map.controls[google.maps.ControlPosition.TOP_LEFT].push(styleControl);

    // Set the map's style to the initial value of the selector.
    var styleSelector = document.getElementById('style-selector');
    map.setOptions({ styles: styles[styleSelector.value] });

    // Apply new JSON when the user selects a different style.
    styleSelector.addEventListener('change', function () {
        map.setOptions({ styles: styles[styleSelector.value] });
    });
}


var styles = {
    default: null,

    retro: [{ "featureType": "water", "stylers": [{ "saturation": 43 }, { "lightness": -11 }, { "hue": "#0088ff" }] }, { "featureType": "road", "elementType": "geometry.fill", "stylers": [{ "hue": "#ff0000" }, { "saturation": -100 }, { "lightness": 99 }] }, { "featureType": "road", "elementType": "geometry.stroke", "stylers": [{ "color": "#808080" }, { "lightness": 54 }] }, { "featureType": "landscape.man_made", "elementType": "geometry.fill", "stylers": [{ "color": "#ece2d9" }] }, { "featureType": "poi.park", "elementType": "geometry.fill", "stylers": [{ "color": "#ccdca1" }] }, { "featureType": "road", "elementType": "labels.text.fill", "stylers": [{ "color": "#767676" }] }, { "featureType": "road", "elementType": "labels.text.stroke", "stylers": [{ "color": "#ffffff" }] }, { "featureType": "poi", "stylers": [{ "visibility": "off" }] }, { "featureType": "landscape.natural", "elementType": "geometry.fill", "stylers": [{ "visibility": "on" }, { "color": "#b8cb93" }] }, { "featureType": "poi.park", "stylers": [{ "visibility": "on" }] }, { "featureType": "poi.sports_complex", "stylers": [{ "visibility": "on" }] }, { "featureType": "poi.medical", "stylers": [{ "visibility": "on" }] }, { "featureType": "poi.business", "stylers": [{ "visibility": "simplified" }] }],
    light: [{ "featureType": "road", "elementType": "all", "stylers": [{ "visibility": "on" }] }, { "featureType": "water", "elementType": "all", "stylers": [{ "color": "#74abc3" }] }],
    hiding: [
      {
          featureType: 'poi.business',
          stylers: [{ visibility: 'off' }]
      },
      {
          featureType: 'transit',
          elementType: 'labels.icon',
          stylers: [{ visibility: 'off' }]
      }
    ]
};