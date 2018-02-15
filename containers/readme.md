# Container for windows
## building
cd logiloader

run buildcontainer.cmd

## running


# Container for rpi3
## building
cd logiloader

run buildcontainer_rpi3

## running
The real logi_loader use the Pi I2C bus to detect LogiPi board, and SPI bus to upload Xilinx BIT on FPGA.

This buses must be mapped inside the container :

	docker run --device /dev/i2c-1 --device /dev/spidev0.1 -it logi_loader_rpi3


An other way to run logi_loader in a container,  is launching the container as privileged. 
for testing, it's fine ... but it's preferable to reduce the surface attack/risk at its minimal level.

	docker run --privileged -it logi_loader_rpi3 
