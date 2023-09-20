# Employee-Directory

This small project was a challenge set forth by a youtuber - video found [here](https://www.youtube.com/watch?v=_WLgwj0r5wg&t=79s).

#### Requirements for challenge
- Build an employee directory with both a web and desktop UI
- Use an API to process all data
- Store the data in a database

#### Additional requirements set by me
- Build a mobile app component 
- Add ability to add employee across all apps (work in progess)

# Tech Used

- .NET 7
- Blazor Server
- WinForms
- PlanetScale
- Ngrok
- React Native

# Setup Ngrok

Ngrok was used to expose my local API to the internet to then call the endpoint from
the mobile app for development.

- Sign up for an account and download ngrok [here](https://ngrok.com/)
- Alternatively, if on macOS, download through brew
```
brew install --cask ngrok
```

- go through the setup steps given on the ngrok dashboard

- run the following command once setup

```
ngrok http [URL FOR LOCAL API]
```

- this will generate a url you can access your local endpoint at