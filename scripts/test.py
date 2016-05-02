from sys import exit
import ctypes
from ctypes import *
import os

# load the dll library 
a = ctypes.cdll.LoadLibrary("DERMSInterface.dll")
appConfig = c_wchar_p(os.path.realpath("app.config"))
a.loadAppConfig(appConfig)

s = a.getHello()
print s

carray = (ctypes.c_wchar_p * 4)()

      appConfig = os.path.realpath("app.config")

# full path required for this call. Sorry
a.loadAppConfig('Z:/git/opendms/DERMSInterface/DERMSInterface/bin/x86/Release/app.config');

# get the ders for the DERGroup
print("1")
ders = a.requestDERGroupMembers("foo10.xml", "1234-5678")
print("3")
ders.restype = ctypes.POINTER(ctypes.c_char_p * 10)
print("4")
result = ders("foo10.xml", "1234-5678")
print("5")
print(result.value)
print("6")

# cast to string
#s = ctypes.cast(ders, ctypes.c_char_p)



# print
#print("return = ",s.value)