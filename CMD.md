## Command

```bash
echo WORKING_DIR=(pwd)/working > .env

docker run --name tmp-nginx-container -d nginx
docker cp tmp-nginx-container:/etc/nginx/nginx.conf (pwd)/working/nginx.conf

docker rm tmp-nginx-container -f
docker ps
```