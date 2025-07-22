# Docker Logging & Audit System

This project demonstrates a centralized logging and audit solution for Docker environments using **Fluentd**, **Elasticsearch**, and **Docker's audit log driver**. The stack enables log aggregation, compliance-ready log storage, and audit trails for container events.


## Key Concepts

- **Log Aggregation:** Centralize logs from all containers in one place for search and analysis.
- **Compliance:** Store logs in Elasticsearch for long-term retention and compliance requirements.
- **Audit Logging:** Use Docker's audit log driver to capture security-relevant container events.


## Components

- **Elasticsearch:** Stores all logs and audit records, enabling search and compliance archiving.
- **Fluentd:** Aggregates Docker container logs and forwards them to Elasticsearch.
- **Docker Audit Logging:** Uses the `audit` log driver to generate audit events for container actions.

