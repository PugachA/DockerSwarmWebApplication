```
docker build -f WebApplication\Dockerfile -t pugacha/webapplication:2.0 --force-rm --no-cache .
docker run -d -p 5555:80 pugacha/webapplication:1.0
docker service create --name webapplication --replicas 3 -p 5555:80 pugacha/webapplication
docker stack deploy -c docker-compose.yml webapplication
```