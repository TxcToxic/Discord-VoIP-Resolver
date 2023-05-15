import socket

server_name = input("VOIP SRV NAME > ")
srv1 = server_name + ".discord.media"
srv2 = server_name + ".discord.gg"

try:
    ipaddr = socket.gethostbyname(server_name)
    ipaddr2 = socket.gethostbyname(server_name)
    print(ipaddr + "/media")
    print(ipaddr2 + "/gg")
except:
    print("Failed to resolve")
