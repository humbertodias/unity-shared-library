# https://www.cprogramming.com/tutorial/shared-libraries-linux-gcc.html

# x64
CC=gcc
# arm
#CC=arm-linux-gnueabi-gcc
CFLAGS=

so:	pic
	$(CC) $(CFLAGS) -shared -o libcalc.so calc.o

so-debug:	pic
	$(CC) $(CFLAGS) -shared -g -o libcalc.so calc.o

so-x86:
	mkdir -p build/x86 && \
	$(MAKE) CFLAGS=-m32 so && \
	mv *.so build/x86

so-x64:
	mkdir -p build/x64 && \
	$(MAKE) CFLAGS=-m64 so && \
	mv *.so build/x64

so-arm:
	mkdir -p build/arm && \
	$(MAKE) CC=arm-linux-gnueabi-gcc so && \
	mv *.so build/arm

so-all:	so-arm	so-x86	so-x64
	cp -r build/ ../calc-cli-unity/Assets/Plugins/calc

pic:
	$(CC) $(CFLAGS) -c -Wall -Werror -fpic calc.c

test:
	$(CC) -L. -Wall -o test test.c -lcalc

run:
	LD_LIBRARY_PATH=.:${LD_LIBRARY_PATH} && \
	./test

dump:
	objdump -t libcalc.so	

gcc-arm:
	sudo apt install gcc-arm-linux-gnueabi

clean:
	rm -rf *.o libcalc.so test build