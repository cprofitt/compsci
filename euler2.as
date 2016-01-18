	mov ecx, 1
	mov edx, 0
	xor ebx, ebx	; sum
_0:	test ecx, 1
	jne _odd
_even:	add ebx, ecx
_odd:	xadd ecx, edx
	cmp ecx, 1000000
	jc _0
