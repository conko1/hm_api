# How to run this project using Docker-Compose for local development

Follow these steps to run the provided `docker-compose.yml`.

## 1. Install Docker Desktop

## 2. Verify Docker Compose Installation
Docker Compose is bundled with Docker Desktop. After installing Docker Desktop, verify Docker Compose by running:
```bash
docker-compose --version
```

## 3. Prepare the Project Files
Pull entire git repository into any local directory e.g. `/your-directory`.\
Ensure that your project structure looks like this:
```bash
/your-directory
  ├── api/
  │   └── Dockerfile
  └── docker-compose.yml
  ```
This ensures that the Dockerfile for the ASP.NET Core API is located inside the api folder as expected by the docker-compose.yml.

## 4. Run Docker Compose

Open a terminal (PowerShell or Command Prompt) and navigate to the folder where your docker-compose.yml is located
Then run:
```bash
docker-compose up --build
```

## 5. Access the Services

Live server should be accessible at `http://localhost:8080`.

Database should be accessible at `localhost:1521` with credentials `username: admin` and `password: StrongPWD1`.