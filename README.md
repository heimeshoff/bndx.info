# Source files for Bndx.info

```
# Have Node and dotnet SDK in the newest version ;)

# Install paket as a dotnet tool (better package management for .Net)
dotnet tool restore

# Install dotnet dependencies using paket (will use paket.references)
dotnet paket restore

# Using Yarn
yarn install
```

After that, start up Webpack Development Server:

```
yarn watch
```

Webpack Development Server will watch `./src/style.css` and `./tailwind.config.js` and rebuild your stylesheet on every change. 
Of course all changes to your *.fs files will be quickly transpiled to JavaScript by Fable.
You'll have a hot reloading website under localhost:8080

## Build and deploy

```
yarn build
```

Upload the content of the folder '/public' to the webserver (which in this case is the gh-pages branch of this repository).