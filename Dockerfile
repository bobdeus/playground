FROM mysql:latest 
LABEL Author="mlund"
EXPOSE 3306
ENV MYSQL_ROOT_PASSWORD=Password1
COPY ./dbinit /docker-entrypoint-initdb.d
