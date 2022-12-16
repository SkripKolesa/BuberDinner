# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Artem",
    "lastName": "Novikov",
    "email": "tim@example.com",
    "password": "qwerty01!"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstName": "Artem",
    "lastName": "Novikov",
    "email": "tim@example.com",
    "token": "gdfTg..xdfwefPSDf"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "tim@example.com",
    "password": "qwerty01!"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstName": "Artem",
    "lastName": "Novikov",
    "email": "tim@example.com",
    "token": "gdfTg..xdfwefPSDf"
}
```