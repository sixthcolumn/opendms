from sys import exit
import ctypes
from ctypes import *

def main():
	# load the dll library 
	a = ctypes.cdll.LoadLibrary("DERMSInterface.dll")

	# full path required for this call. Sorry
	a.loadAppConfig('Z:/git/opendms/DERMSInterface/DERMSInterface/bin/x86/Release/app.config');

	func = a.requestDERGroupMembers2
	func.argtypes = [c_wchar_p,c_wchar_p]
	func.restype = c_wchar_p

	xml = func('foo10.xml', '1234-5678')

	s = cast(xml, c_char_p).value.decode("utf-8")
	print("returned : " + s)


if __name__ == "__main__":
	try:
		main()
	except SystemExit as e:
		print(e)



