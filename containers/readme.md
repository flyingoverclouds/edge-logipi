# base Container image for windows
## building
cd logiloader

run buildcontainer.cmd



# base Container image for rpi3
## building
cd logiloader

run buildcontainer_rpi3

# Bitstream container Image

	FROM logi_loader_rpi3
	WORKDIR /bitstreams
	COPY pushbuttons_leds_assign.bit .

	# pass the command (ie.  the bitstream to upload) to the base container
	CMD ["/bitstreams/pushbuttons_leds_assign.bit"]


## running
The real logi_loader use the RPi3 I2C bus to detect LogiPi board, and SPI bus to upload Xilinx bitstream in the FPGA.

This two buses must be accessible from the container :

	docker run --device /dev/i2c-1 --device /dev/spidev0.1 -it MyBitstreamContainerImage


An other way to run logi_loader in a container, is launching the container with 'privilege'.  
For testing, it's fine ... but it's preferable to reduce the surface attack/risk at its minimal level.

	docker run --privileged -it MyBitstreamContainerImage 


