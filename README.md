# 🛡️ Insurance Calculator – Full Stack Solution

A complete end-to-end **Insurance Calculator Application** built using:

- **.NET 8 Web API** (Backend)  
- **Angular Frontend**  
- **Clean folder separation for backend & frontend**  
- **Database ER Diagram included**

This system allows users to enter their details (age, policy type, sum insured, etc.) and calculates the final insurance premium based on configurable rules.

---

## Project Folder Structure

```
InsuranceCalculatorSolution/
│
├── backend/
│   └── InsuranceCalculator.API/
│       ├── Controllers/
│       ├── Models/
│       ├── Properties/
│       ├── bin/
│       ├── obj/
│       ├── InsuranceCalculator.API.csproj
│       └── Program.cs
│
├── frontend/
│   └── insurance-ui/
│       ├── src/
│       ├── angular.json
│       ├── package.json
│       ├── package-lock.json
│
├── Insurance_DB_Diagram.png
├── .gitignore
└── README.md
```

---

# 🚀 Backend – .NET 8 Web API  
**Location:** `/backend/InsuranceCalculator.API/`

## 📌 Features

- .NET 8 Web API  
- Controller for premium calculation  
- Models for Ocupation and Premium Rules  
- Structured routing  
- JSON-based API responses  
- Swagger UI enabled for API documentation  
- Clean project layout following best practices  

---

## Run the Backend

- Open InsuranceCalculator.API.csproj in Visual Studio 2022/Insiders
- Set InsuranceCalculator.API as startup
- Press F5
- API will launch at: http://localhost:5000

Open Swagger:
```
http://localhost:5000/swagger/index.html
```
# 🎨 Frontend – Angular Application  
**Location:** `/frontend/insurance-ui/`

## Run the Frontend
```
cd frontend/insurance-ui
npm install
ng serve --open
```

Runs at:
```
http://localhost:4200
```
Angular Live Development Server is listening on localhost:4200, open your browser on http://localhost:4200/ 

## 📌 Features

- Angular SPA  
- Form to input insurance details  
- Validations for age, policy type, sum insured  
- Calls backend API  
- Displays final premium  
- Modular folder structure  
---

# 🗄️ Database Diagram

ER diagram located at:
Insurance_DB_Diagram.png
```

# 📚 Tech Stack

| Layer | Technology |
|------|------------|
| Backend | .NET 8 Web API |
| Frontend | Angular |
| Database | Diagram |
| Tools | Swagger, NPM |
