![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)
![Alpine Linux](https://img.shields.io/badge/Alpine_Linux-%230D597F.svg?style=for-the-badge&logo=alpine-linux&logoColor=white) 
![Wireguard](https://img.shields.io/badge/wireguard-%2388171A.svg?style=for-the-badge&logo=wireguard&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
# rest2wireguard
### REST2WG is an Alpine-based WebAPI-managed Wireguard server.
<br/>

## Quick start:
    docker run --cap-add NET_ADMIN -p 51850:51820/udp -p 51851:5000/tcp --env REST2WG_ALLOW_NOAUTH=true luminodiode/rest2wireguard
You will get the image listening 51850 by Wireguard and 51851 by WebAPI without authorization request header requred. Dont forget to allow it in your UFW if there is some.
