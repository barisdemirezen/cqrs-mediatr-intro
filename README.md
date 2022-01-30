
# CQRS MediatR Intro 🎉

.NET 6 Web API project that implements CQRS Pattern.

## About it 📝

This project is created to see benefits of popular CQRS pattern and MediatR package. Folders are seperated by commands, queries and handlers. I saw that it can be difficult to find specific file with this structure. So it can be better to pack a handler, request and response together.

## Install, run, dev 🏗️

Open ```CQRS-Intro.sln``` with Visual Studio, then start ```CQRS-Intro```

## API Usage ✨

#### Shows all products

```
  GET /api/products
```
#### Shows product with given id

```
  GET /api/products/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `number` | **Required**. Id of product |

#### Adds product to products. Returns Id of created product.

```
  POST /api/products/
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `title`      | `string` | Title of product |
| `price`      | `number` | Price of product |

#### Deletes product with given Id.
 
 ```http
  DELETE /api/products/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `number` | **Required**. Id of product |

## Badges 📌


![](https://img.shields.io/github/last-commit/barisdemirezen/cqrs-mediatr-intro/main?style=flat-square)
![](https://img.shields.io/badge/version-.NET--6-blue?style=flat-square)