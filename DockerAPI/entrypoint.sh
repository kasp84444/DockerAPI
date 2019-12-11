﻿#! /bin/bash

set -e
run_cmd ="dotnet run --server.urls http://*:80"

until dotnet ef database update; do
>&2 echo "SQL Server starting"
sleep 1
done

>&2 echo "Sql running"
exec $run_cmd