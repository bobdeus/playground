FROM mysql:latest 
EXPOSE 3306:3306/tcp
ENV MYSQL_ROOT_PASSWORD=Password1
COPY ./dbinit /docker-entrypoint-initdb.d