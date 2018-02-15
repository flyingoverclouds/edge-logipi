#include <sys/syscall.h>

const char message[] = "\n  Hello  By Nicolas\n\n";


void _start() {
	syscall(SYS_write, 1, message, sizeof(message));
	syscall(SYS_exit, 0);
}

