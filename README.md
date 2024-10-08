# EncoreTix Backend - Setup and Run Guide (Visual Studio 2022)

This guide provides step-by-step instructions to set up and run the backend application using Visual Studio 2022.

## Prerequisites

Before you start, make sure you have the following installed:

- **Visual Studio 2022**
- **.NET SDK** (compatible with the project)
- **API Key for Ticketmaster**

## Getting Started

### 1. Clone the Repository

Clone the repository to your local machine:

```bash
git clone https://github.com/xambuddy/encore-tix.git
```

### 2. Open the Project in Visual Studio 2022

Launch Visual Studio 2022.
Click on Open a project or solution.
Navigate to the cloned repository and select the solution file (.sln).

### 3. Update the appsettings.json File

Locate the appsettings.json file (found under the Properties folder or in the root directory).
Open the file and update the "ApiKey" under "TicketmasterConfig" with your API key

### 4. Run the Application

Set the backend project as the Startup Project:
- Right-click on the backend project in the Solution Explorer.
- Select Set as Startup Project.

Press F5 or click on the Run button to start the application.

### 5. Test the API Endpoints

Navigate to https://localhost:7177/swagger/index.html
