# CI/CD Pipeline for .NET Console App with Docker, GitHub Actions, Azure Container Registry & SonarQube

This project demonstrates a modern, secure CI/CD pipeline for a .NET Console Application. The pipeline features containerization (multi-stage Docker build), automated builds and testing in GitHub Actions, code quality gates with SonarQube, and secure deployment to Azure Container Registry (ACR).

---

## Key Concepts

- **Multi-stage Docker builds:** Efficient, layered Docker image creation for .NET apps.
- **Pipeline gates:** Automated testing and code quality analysis before deployment.
- **Automated image tagging:** CI/CD tags images with Git commit SHA and version.
- **Secure credential management:** Uses GitHub secrets for Azure and SonarQube credentials.