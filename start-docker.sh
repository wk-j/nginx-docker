export ROOT=$(pwd)/.working

docker-compose down
docker-compose build
docker-compose up


