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

	xml = c_wchar_p()
	val = c_double(7.5)

	rc = a.dispatchDERGroup("enterpriseConfig.xml", "128", "RealPower", byref(xml), False, val)

	print("createDERGroup return code =  " + str(rc))

	s = cast(xml, c_wchar_p).value
	print("returned : " + s)


if __name__ == "__main__":
	try:
		main()
	except SystemExit as e:
		print(e)


