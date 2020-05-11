# Introduction 
This repository contains the source code of the _Immedia-Skills-Assessment_. The main project for consumers is the Api used for searching interesting landmarks around a location, with photos and relevant details. 

# Projects
| Project | Description |
| --------------- | -------------------------------------------------------------------|
| Assessment.API | Contains the endpoints to the various location services provided to the consumer.  | 
| Assessment.Domain | Contains the interfaces and models used on the solution.  |
| Assessment.Service | Contains the classes required to communicate with the Foursquare Api and retrieve settings from appsetting.json file. |
| Assessment.DataAccess | Contains the code implementation that connects to a mongodb and provide CRUD operations.  |

# Build and Test

## Usage

### Request

`GET /venues/{locationName}"`

### Response

    {
    "meta": {
        "code": 200,
        "requestId": "5eb994ca9fcb92001bbf3bfe"
    },
    "response": {
        "venues": [
            {
                "id": "4ba62e83f964a520923939e3",
                "name": "Sun Coast Casino",
                "contact": {},
                "location": {
                    "address": "Battery Beach Rd.",
                    "lat": -29.835883944704236,
                    "lng": 31.034643888484666,
                    "labeledLatLngs": [
                        {
                            "label": "display",
                            "lat": -29.835883944704236,
                            "lng": 31.034643888484666
                        }
                    ],
                    "distance": 2196,
                    "postalCode": "4025",
                    "cc": "ZA",
                    "city": "ITheku",
                    "state": "KwaZulu-Natal",
                    "country": "iNingizimu Afrika",
                    "formattedAddress": [
                        "Battery Beach Rd.",
                        "ITheku",
                        "4025",
                        "iNingizimu Afrika"
                    ]
                },
                "categories": [
                    {
                        "id": "4bf58dd8d48988d17c941735",
                        "name": "Casino",
                        "pluralName": "Casinos",
                        "shortName": "Casino",
                        "icon": {
                            "prefix": "https://ss3.4sqi.net/img/categories_v2/arts_entertainment/casino_",
                            "suffix": ".png"
                        },
                        "primary": true
                    }
                ],
                "verified": false,
                "stats": {
                    "tipCount": 0,
                    "usersCount": 0,
                    "checkinsCount": 0,
                    "visitsCount": 0
                },
                "beenHere": {
                    "count": 0,
                    "lastCheckinExpiredAt": 0,
                    "marked": false,
                    "unconfirmedCount": 0
                },
                "hereNow": {
                    "count": 0,
                    "summary": "Nobody here",
                    "groups": []
                },
                "referralId": "v-1589220513",
                "venueChains": [],
                "hasPerk": false
            }
        ],
        "confident": false
    }
}
    
### Request

`POST /venues`

    {
    "Latitude": -29.844776,
	"Longitude": 31.014339
	}
  

### Response

    {
    "meta": {
        "code": 200,
        "requestId": "5eb994ca9fcb92001bbf3bfe"
    },
    "response": {
        "venues": [
            {
                "id": "4ba62e83f964a520923939e3",
                "name": "Sun Coast Casino",
                "contact": {},
                "location": {
                    "address": "Battery Beach Rd.",
                    "lat": -29.835883944704236,
                    "lng": 31.034643888484666,
                    "labeledLatLngs": [
                        {
                            "label": "display",
                            "lat": -29.835883944704236,
                            "lng": 31.034643888484666
                        }
                    ],
                    "distance": 2196,
                    "postalCode": "4025",
                    "cc": "ZA",
                    "city": "ITheku",
                    "state": "KwaZulu-Natal",
                    "country": "iNingizimu Afrika",
                    "formattedAddress": [
                        "Battery Beach Rd.",
                        "ITheku",
                        "4025",
                        "iNingizimu Afrika"
                    ]
                },
                "categories": [
                    {
                        "id": "4bf58dd8d48988d17c941735",
                        "name": "Casino",
                        "pluralName": "Casinos",
                        "shortName": "Casino",
                        "icon": {
                            "prefix": "https://ss3.4sqi.net/img/categories_v2/arts_entertainment/casino_",
                            "suffix": ".png"
                        },
                        "primary": true
                    }
                ],
                "verified": false,
                "stats": {
                    "tipCount": 0,
                    "usersCount": 0,
                    "checkinsCount": 0,
                    "visitsCount": 0
                },
                "beenHere": {
                    "count": 0,
                    "lastCheckinExpiredAt": 0,
                    "marked": false,
                    "unconfirmedCount": 0
                },
                "hereNow": {
                    "count": 0,
                    "summary": "Nobody here",
                    "groups": []
                },
                "referralId": "v-1589220513",
                "venueChains": [],
                "hasPerk": false
            }
        ],
        "confident": false
    }
}
    
### Request

`GET /venues/{venueId}/venue/images`

### Response

    {
    "meta": {
        "code": 200,
        "requestId": "5eb97ee8fb34b5001bf57a07"
    },
    "response": {
        "photos": {
            "count": 31,
            "items": [
                {
                    "id": "59d3ab40838e5941de553a86",
                    "createdAt": 1507044160,
                    "prefix": "https://fastly.4sqi.net/img/general/",
                    "suffix": "/81003158_9RvUFmNubtB6AQC4BNvKkSwQ_p8g2V2KRhaQa1uka8Y.jpg",
                    "width": 1440,
                    "height": 1920,
                    "user": {
                        "id": "81003158",
                        "firstName": "Asude",
                        "lastName": "M",
                        "photo": {
                            "prefix": "https://fastly.4sqi.net/img/user/",
                            "suffix": "/81003158-DRG3PBU3Y3FLUJD3.jpg"
                        }
                    },
                    "visibility": "public"
                }
            ]
        }
    }
}
    
### Request

`GET /venues/{photoId}/image/details`

### Response

    {
    "meta": {
        "code": 200,
        "requestId": "5eb9952c9fcb92001bc040fd"
    },
    "response": {
        "photo": {
            "id": "5284c47511d29dbe6884cd59",
            "createdAt": 1384432757,
            "source": {
                "name": "Foursquare for BlackBerry",
                "url": "https://foursquare.com/download/#/blackberry"
            },
            "prefix": "https://fastly.4sqi.net/img/general/",
            "suffix": "/13510447_VNvno9F4NhIdH_RRLi2FDhYHxL0dEwBGSvfRR9kJP3E.jpg",
            "width": 640,
            "height": 480,
            "user": {
                "id": "13510447",
                "firstName": "Jude",
                "lastName": "B",
                "photo": {
                    "prefix": "https://fastly.4sqi.net/img/user/",
                    "suffix": "/DYYOZIVYFEQ22WQM.jpg"
                }
            },
            "visibility": "public",
            "venue": {
                "id": "4bb322d742959c74978f212c",
                "name": "Smartxchange",
                "contact": {},
                "location": {
                    "address": "5 Walnut Road",
                    "lat": -29.855823752441797,
                    "lng": 31.02904454143683,
                    "labeledLatLngs": [
                        {
                            "label": "display",
                            "lat": -29.855823752441797,
                            "lng": 31.02904454143683
                        }
                    ],
                    "postalCode": "4001",
                    "cc": "ZA",
                    "city": "ITheku",
                    "state": "KwaZulu-Natal",
                    "country": "iNingizimu Afrika",
                    "formattedAddress": [
                        "5 Walnut Road",
                        "ITheku",
                        "4001",
                        "iNingizimu Afrika"
                    ]
                },
                "categories": [
                    {
                        "id": "4bf58dd8d48988d124941735",
                        "name": "Office",
                        "pluralName": "Offices",
                        "shortName": "Office",
                        "icon": {
                            "prefix": "https://ss3.4sqi.net/img/categories_v2/building/default_",
                            "suffix": ".png"
                        },
                        "primary": true
                    }
                ],
                "verified": false,
                "stats": {
                    "tipCount": 0,
                    "usersCount": 0,
                    "checkinsCount": 0,
                    "visitsCount": 0
                },
                "beenHere": {
                    "count": 0,
                    "lastCheckinExpiredAt": 0,
                    "marked": false,
                    "unconfirmedCount": 0
                }
            }
        }
    }
}

## App settings 
```json
{
"DatabaseSettings": {
    "ConnectionString": "mongodb://127.0.0.1:27017/?compressors=disabled&gssapiServiceName=mongodb",
    "DatabaseName": "LandmarkDB",
    "VenuesCollectionName": "Venues",
    "PhotosCollectionName": "Photos"
  },
 "Foursquare": {
    "Credentials": {
      "ClientId": "BNUEH3OHOVHXMGMWZLPG5YIKCNJJSMIYCJGHU4M3JKB5EZWZ",
      "ClientSecret": "DPGJPVWVGV3PU2QDUSVLNHRSFGHEMBFZTWPT0GTGSXMV3ABD"
    },
    "Configuration": {
      "Uri": "https://api.foursquare.com/v2", 	
      "Version": 20200509,						
      "Radius": 1000, 							<!--- Limit results to venues within this many meters of the specified location. -->
      "Intent": "browse", 						<!--- Browse searches an entire region instead of only finding venues closest to a point. -->
      "limit": 10, 								<!--- Number of results returned. -->
      "CategoryId": "4d4b7104d754a06370d81259" 	<!--- Arts & Entertainment Category Id that enables landmarks to be retrieved for a location. -->
    }
  }
}
```
### ToDo-List
* Resolve duplicate index id error: A bulk write operation resulted in one or more errors.

### Optional improvements
* Allow the user to search through the saved images and locations.
* The retrieval of location and image data can be run in the background as this has the potential to be a lengthy task.
* Allow users to create accounts and have a custom list of locations per user.

# Documentation

# References
