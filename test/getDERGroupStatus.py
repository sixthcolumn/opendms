from sys import exit
import ctypes
from ctypes import *
import os


def main():
	# load the dll library 
	a = ctypes.cdll.LoadLibrary("DERMSInterface.dll")

	# full path required for this call. Sorry
	appConfig = os.path.realpath("app.config")
	a.loadAppConfig(appConfig)

	xml = c_wchar_p()

	rc = a.getDERGroupStatus("enterpriseConfig.xml", "dergroup1", "RealPower", byref(xml))

	print("createDERGroup return code =  " + str(rc))

	s = cast(xml, c_wchar_p).value
	print("returned : " + s)


if __name__ == "__main__":
	try:
		main()
	except SystemExit as e:
		print(e)


