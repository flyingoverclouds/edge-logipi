FROM microsoft/dotnet 

WORKDIR /app
COPY . ./

WORKDIR /bitstreams
#COPY pushbuttons_leds_assign.bit .

ENTRYPOINT ["dotnet","/app/logi_loader_x86.dll"]
#CMD ["bash"]
#CMD ["/bitstreams/pushbuttons_leds_assign.bit"]