# Chaos Engineering with Docker (.NET + Gremlin)

This project demonstrates chaos engineering in a Dockerized .NET environment using [Gremlin](https://www.gremlin.com/) to simulate container failures such as crashes and network latency. The goal is to help you test and improve the resilience of your .NET microservices.

---

## Key Concepts

- **Chaos Engineering:** Intentionally introduce failures to validate system resilience.
- **Container Failure Simulation:** Crash and disrupt containers using Gremlin attacks.
- **Network Chaos:** Simulate latency, packet loss, and other network issues.
- **.NET Microservice Environment:** Realistic .NET service targets for chaos experiments.

## Components

- **.NET Web API:** Example microservice.
- **Gremlin Container:** Runs the Gremlin agent, allowing you to inject chaos via the Gremlin web UI or CLI.
- **Docker Compose:** Orchestration for .NET service and Gremlin agent.