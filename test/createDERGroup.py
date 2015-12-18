from sys import exit
import ctypes
from ctypes import *
import os

def main():
	# load the dll library 
	a = ctypes.cdll.LoadLibrary("DERMSInterface.dll")


	appConfig = os.path.realpath("app.config")
	# full path required for this call. Sorry
	a.loadAppConfig(appConfig)

	# array size is 10, this is same as in the CIMXML.cs
	# file, ie:         const int _arraySize = 10;
	# if you bump this, bump that array too
	x = (ctypes.c_wchar_p * 10)()
	x[0] = c_wchar_p('der1')
	x[1] = c_wchar_p('der2')

	# return point for the xml data structure returned by createDERGroup
	xml = c_wchar_p()

	rc = a.createDERGroup("enterpriseConfig.xml", "dergroup1", byref(x), byref(xml))

	print("createDERGroup return code =  " + str(rc))

	s = cast(xml, c_wchar_p).value
	print("returned : " + s)


if __name__ == "__main__":
	try:
		main()
	except SystemExit as e:
		print(e)


