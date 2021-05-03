FROM mysql:latest

ENV MYSQL_ROOT_PASSWORD=docker

COPY ./dbInit /docker-entrypoint-initdb.d

