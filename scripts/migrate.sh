#!/bin/bash

if [ -z "$1" ]; then
    echo "Usage: ./migrate.sh <MigrationName>"
    exit 1
fi

INPUT_NAME=$1
TIMESTAMP=$(date -u +"DATE-%Y-%m-%d_TIME-%H-%M-%S")
MIGRATION_NAME="${INPUT_NAME}_${TIMESTAMP}"

dotnet ef migrations add "$MIGRATION_NAME" \
    --project ../src/Backy.Infrastructure \
    --startup-project ../src/Backy.Api

dotnet ef database update \
    --project ../src/Backy.Infrastructure \
    --startup-project ../src/Backy.Api
