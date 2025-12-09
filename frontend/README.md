# Frontend (React + TypeScript)

This is a minimal Vite React + TypeScript app to consume the backend.

Quick start:

1. Install dependencies

```powershell
cd frontend; npm install
```

2. Run the dev server

```powershell
npm run dev
```

3. Open the app at http://localhost:5173

Notes:

- The frontend expects a backend route that returns flights in JSON. By default the sample component fetches `https://localhost:5001/Flights` — adjust the URL or create an API endpoint such as `/api/flights` that returns JSON.
- CORS is permitted from `http://localhost:5173` in the backend `Program.cs` for development.
