<a href="#">
    <img src="https://raw.githubusercontent.com/paulrozhkin/RestaurantClientApplication/master/app/src/main/res/drawable/logo.png" title="Tamagotchi" alt="Tamagotchi" width="200">
</a>

# Tamagotchi Server

This is the server application for the Tamagotchi restaurant chain.
The server provides an opportunity for customers to work with booking tables and ordering dishes in a restaurant.
It also provides an opportunity for the administration to manage the infrastructure of the restaurant.

---

## Linked Repositories
- [Web client](https://github.com/paulrozhkin/tamagotchi-web-client)
- [Android client application](https://github.com/paulrozhkin/tamagotch-android-client)
- [Android stuff application](https://github.com/ForsaiR/RestaurantEmployerApplication)
- [Tamagotchi Remote Library](https://github.com/paulrozhkin/tamagotchi-remote-library)
- [NodeJs server (Old)](https://github.com/paulrozhkin/tamagotchi-server)

---

## Documentation
- [OpenApi 3 Specification](https://app.swaggerhub.com/apis/paul-rozhkin/itmo-tamagotchi/)
- [Course Report](https://docs.google.com/document/d/12Z9ZYv56fRUkFW4QWif3M2M6Dqp77mSlRNeztwmCf7Q/edit#)

---

## Installation

### Clone
- Clone this repo to your local machine using `git clone https://github.com/paulrozhkin/tamagotchi-server-dotnet`

### Setup

- Install [PostgreSQL](https://www.postgresql.org/download/) on your machine
- Create `tamagotchi` database
- Add ConnectionStrings to appsettings.json like a:
```
"ConnectionStrings": {
    "DefaultConnection": "Server=127.0.0.1;port=5432;user id=postgres;password=postgres;database=tamagotchi;pooling = true"
  }
```

---
## Using
### Tools:
- Database: PostgreSQL
    - Database adapter: [node-postgres](https://node-postgres.com/)
    - For migration uses: [node-pg-migrate](https://salsita.github.io/node-pg-migrate/#/)
---

## Contributing

> To get started...

### Step 1

- **Option 1**
    - 🍴 Fork this repo!

- **Option 2**
    - 👯 Clone this repo to your local machine using `https://github.com/paulrozhkin/tamagotchi-server-dotnet`

### Step 2

- **HACK AWAY!** 🔨🔨🔨

### Step 3

- 🔃 Create a new pull request using <a href="https://github.com/paulrozhkin/tamagotchi-server-dotnet/pulls" target="_blank">`https://github.com/paulrozhkin/tamagotchi-server-dotnet/pulls`.

---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright 2020 © <a href="https://github.com/paulrozhkin" target="_blank">Paul Rozhkin</a>.

