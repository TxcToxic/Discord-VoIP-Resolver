import socket

server_name = input("VOIP SRV NAME > ") + ".discord.gg"

try:
    ipaddr = socket.gethostbyname(server_name)
    print(ipaddr)
except:
    print("Failed to resolve")