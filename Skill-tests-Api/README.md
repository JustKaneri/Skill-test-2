# Skill-tests-2 - API

## Зависимости: 

> AutoMapper 12.0.0

> AutoMapper.Extensions.Microsoft.DependencyInjection 12.0.0

> Microsoft.EntityFrameworkCore.InMemory  7.0.0

> Microsoft.EntityFrameworkCore.SqlServer 7.0.0


## Endpoints

### Point controller

| Name | Discript| Url | Parameters | Body request |Responce |
| :---         |     :---:      | :---         |     :---:      |          ---: |          ---: |
| get_points  |  Получить список точек  | http://[host-name]/api/v1/points    | -    | - | [ {"id": int, "xcoordinate": int,    "ycoordinate": int, "radius": int, "colorHex": "string", "comments": [{"id": int, "content": "string", "backColorHex": "string",     "pointId": int }] } ]|
| point_delete  |  Удалить точку  | http://[host-name]/api/v1/point/{Parameters}    | idPoint -integer   | - | {"id": int, "xcoordinate": int,    "ycoordinate": int, "radius": int, "colorHex": "string", "comments": [{"id": int, "content": "string", "backColorHex": "string",     "pointId": int }] } |
| point_create | Создать точку  | http://[host-name]/api/v1/point  | - | {"xcoordinate": 0,"ycoordinate": 0,"radius": 0,"colorHex": "string"} | {"id": int, "xcoordinate": int, "ycoordinate": int, "radius": int, "colorHex": "string", "comments": [{"id": int, "content": "string", "backColorHex": "string",     "pointId": int }] } |

### Comment controller

| Name | Discript| Url | Parameters | Body request |Responce |
| :---         |     :---:      | :---         |     :---:      |          ---: |          ---: |
| get_comments  |  Получить список комментариев | http://[host-name]/api/v1/point/{Parameters}/comments    | -    | idPoint - integer | [{"id": int, "content": "string", "backColorHex": "string",     "pointId": int }]|
| comment_delete  |  Удалить комментарий | http://[host-name]/api/v1/comment/{Parameters}    | idComment -integer   | - | {"id": int, "content": "string", "backColorHex": "string",     "pointId": int }|
| comment_create | Создать комментарий  | http://[host-name]/api/v1/point  | { "content": "string","backColorHex": "string"} | {"xcoordinate": 0,"ycoordinate": 0,"radius": 0,"colorHex": "string"} | {"id": int, "content": "string", "backColorHex": "string",     "pointId": int } } |