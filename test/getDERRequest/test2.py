from sys import exit
import ctypes
from ctypes import *

def main():
	# load the dll library 
	a = ctypes.cdll.LoadLibrary("DERMSInterface.dll")

	# full path required for this call. Sorry
	a.loadAppConfig('Z:/git/opendms/DERMSInterface/DERMSInterface/bin/x86/Release/app.config');

	func = a.requestDERGroupMembers
	func.argtypes = [POINTER(c_char_p), POINTER(c_char_p)]
	func.restype = c_int
	groups = c_char_p()
	mrid = c_char_p(b'1234-5678')
	
	rc = func(byref(groups), byref(mrid))
	s = cast(groups, c_char_p).value.decode("utf-8")
	print("returned : " + s + ", rc = " + str(rc))


if __name__ == "__main__":
	try:
		main()
	except SystemExit as e:
		print(e)
