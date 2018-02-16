# use Debian-Stretch-slim for raspbian compability and minimal size
FROM arm32v7/debian:stretch-slim

WORKDIR /logipi
COPY logi_loader . 

WORKDIR /bitstreams
#COPY pushbuttons_leds_assign.bit .

ENTRYPOINT [ "/logipi/logi_loader" ]

#CMD ["/bitstreams/pushbuttons_leds_assign.bit"]
#CMD ["bash"]
