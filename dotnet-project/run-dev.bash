#!/bin/bash
echo "Start"

echo $ASPNETCORE_ENVIRONMENT

dbUrl="jdbc:postgresql://postgres:5432/postgres"
dbUserName="postgres"
dbPassword=""

cd /app/Liquibase/workspace && \

java -jar liquibase.jar \
	--driver=org.postgresql.Driver \
	--classpath=./lib/postgresql.jar \
	--url=$dbUrl \
	--changeLogFile=./changelog/changelog-initschema.xml \
	--username=$dbUserName\
	--password=$dbPassword\
	--defaultSchemaName=public\
	--databaseChangeLogLockTableName="dotnet_project_databasechangeloglock"\
	--databaseChangeLogTableName="dotnet_project_databasechangelog"\
	update && \

java -jar liquibase.jar \
	--driver=org.postgresql.Driver \
	--classpath=./lib/postgresql.jar \
	--url=$dbUrl \
	--changeLogFile=./changelog/changelog-master.xml \
	--username=$dbUserName\
	--password=$dbPassword\
	--defaultSchemaName=dotnet_project\
	update && cd /app/out \
	&& dotnet dotnet-project.dll