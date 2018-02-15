# use Debian-Stretch-slim for  raspbian compability and minimal size
FROM arm32v7/debian:stretch-slim
WORKDIR logipi
COPY logi_loader . 
COPY pushbuttons_leds_assign.bit .
CMD ["/logipi/logi_loader","/logipi/pushbuttons_leds_assign.bit"]
#CMD ["bash"]
