"""Core XML support for Python.

This package contains four sub-packages:

dom -- The W3C Document Object Model.  This supports DOM Level 1 +
       Namespaces.

parsers -- Python wrappers for XML parsers (currently only supports Expat).

sax -- The Simple API for XML, developed by XML-Dev, led by David
       Megginson and ported to Python by Lars Marius Garshol.  This
       supports the SAX 2 API.

etree -- The ElementTree XML library.  This is a subset of the full
       ElementTree XML release.

"""


__all__ = ["dom", "parsers", "sax", "etree"]

# When being checked-out without options, this has the form
# "<dollar>Revision: x.y </dollar>"
# When exported using -kv, it is "x.y".
__version__ = "$Revision$".split()[-2:][0]


_MINIMUM_XMLPLUS_VERSION = (0, 8, 4)


import os

# only prefer _xmlplus if the environment variable PY_USE_XMLPLUS is defined
if 'PY_USE_XMLPLUS' in os.environ:
    try:
        import _xmlplus
    except ImportError:
        pass
    else:
        try:
            v = _xmlplus.version_info
        except AttributeError:
            # _xmlplus is too old; ignore it
            pass
        else:
            if v >= _MINIMUM_XMLPLUS_VERSION:
                import sys
                _xmlplus.__path__.extend(__path__)
                sys.modules[__name__] = _xmlplus
            else:
                del v
