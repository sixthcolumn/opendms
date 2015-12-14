from sys import exit
import ctypes
from ctypes import *

def main():
	# load the dll library 
	a = ctypes.cdll.LoadLibrary("DERMSInterface.dll")

# full path required for this call. Sorry
	a.loadAppConfig('Z:/git/opendms/DERMSInterface/DERMSInterface/bin/x86/Release/app.config');

	func = a.requestDERGroupMembers2
	func.argtypes = [c_wchar_p,c_wchar_p, POINTER(c_char_p)]
	func.restype = c_int

	xml = c_char_p()

	rc = func('foo10.xml', '1234-5678', byref(xml))

	s = cast(xml, c_wchar_p).value
	print("returned : " + s)


if __name__ == "__main__":
	try:
		main()
	except SystemExit as e:
		print(e)


