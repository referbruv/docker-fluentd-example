FROM mysql

# ENV MYSQL_DATABASE=<schema_name> \
#     MYSQL_ROOT_PASSWORD=<password>

ADD ./init/schema.sql /docker-entrypoint-initdb.d

EXPOSE 3306
