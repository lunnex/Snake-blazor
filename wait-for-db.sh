#!/bin/sh

# Ожидание PostgreSQL
until nc -z -v -w30 snake-pg 5432
do
  echo "Waiting for database connection..."
  sleep 1
done

echo "Database is up - executing command"
exec "$@"