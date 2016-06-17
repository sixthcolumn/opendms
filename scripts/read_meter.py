from sys import exit
import ctypes
from ctypes import *
import os

# load the dll library 
a = ctypes.cdll.LoadLibrary("DERMSInterface.dll")

# location of config file
appConfig = c_wchar_p(os.path.realpath("app.config"))

# site to read, c_wchar_p is null terminated unicode
site = c_wchar_p('SITE27')

# load config
a.loadAppConfig(appConfig)

# read meter
r = a.ReadMeter(site)

print (r)
