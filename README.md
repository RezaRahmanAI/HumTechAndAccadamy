# VivaSphere Platform

Modern full-stack showcase inspired by leading Bangladeshi software consultancies. The project contains an Angular 18 frontend styled with Tailwind CSS and a .NET 8 minimal Web API serving structured company content.

## Project structure

```
frontend/            # Angular application with standalone components and Tailwind setup
backend/
  VivaSphere.Api/    # ASP.NET Core Web API with in-memory content repository
```

## Prerequisites

- Node.js 18+
- npm 9+
- .NET 8 SDK (for running the API)

> **Note:** If package restore from npm or dotnet feeds is restricted in your environment, install dependencies manually using an available mirror.

## Setup & development

### Backend

```bash
cd backend/VivaSphere.Api
# restore dependencies
 dotnet restore
# run the API on http://localhost:5000
 dotnet run
```

The API exposes endpoints under `/api`, including `/api/home`, `/api/services`, `/api/products`, `/api/blog`, `/api/careers`, and `/api/contact`.

### Frontend

```bash
cd frontend
# install dependencies (Tailwind + Angular CLI included in package.json)
npm install
# start dev server on http://localhost:4200
npm start
```

Environment configuration lives in `src/app/environments`. By default the Angular app targets `http://localhost:5000/api` for development.

### Building for production

```bash
# frontend
cd frontend
npm run build

# backend (publish)
cd backend/VivaSphere.Api
 dotnet publish -c Release -o out
```

## Features

- Responsive layout with sticky navigation, animated hero, and full home-page section flow.
- Lazy-loaded Angular routes for services, products, blog, careers, contact, and MVP calculator.
- Strongly typed models mirrored between frontend and backend.
- Tailwind-powered design system with marquee animations, cards, and CTA blocks.
- ASP.NET Core Web API returning curated in-memory data and accepting contact requests.

## Testing

- Frontend linting and unit tests can be run with `npm run lint` / `npm test` once dependencies are installed.
- Backend uses .NET minimal APIs; add unit tests as required using xUnit or your preferred framework.

## License

MIT
