# docker-fluentd-example

A Sample Implementation of Docker Container Logging to MySQL using Fluentd. The entire setup is built using Docker-Compose and are custom built with own Dockerfiles. The components include: 

* An API (written in ASP.NET Core that generates logs)
* MySQL database with necessary startup script for loading the schema
* Fluentd with MySQL plugin and fluentd.conf, which writes to the above database

The complete explanation is available at: 

https://referbruv.com/blog/posts/writing-docker-container-logs-to-mysql-using-fluentd