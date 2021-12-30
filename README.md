# Wsl-Dev-Manager
Wsl-Dev-Manager (WDM) is an utility to setup your dev WSL environment

## Goal of this project
From a JSON, setup your WSL environment directly like that:

```json
{
  "softwares": {
    "jetbrains": {
      "toolbox": true,
      "phpstorm": true,
      "rider": true,
      "webstorm": false
    },
    "vscode": {
      "install": true
    }
  },
  "environment": {
    "dotnet": 6,
    "php": "8.0.1"
  },
  "projects": {
    "locations": "~/Projects",
    "repositories": [
      {
        "name": "Project-ZOB",
        "url": "git@github.com:Pi-Bouf/zob.git",
        "private": true
      },
      {
        "name": "Webpack-penis-plugin",
        "url": "git@github.com:webpack/penis-plugin.git",
        "private": false
      }
    ]
  },
  ... etc etc
}
```

With a simple JSON link, it will install everything you need.
