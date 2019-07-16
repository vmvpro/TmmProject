Public Module LibraryVB



    'Attribute VB_Name = "ksConst"
    '   ������!!!
    '   result >-1  �������� ���������� ��� �� ��������� ������
    '   result <0   ��������� ������ - ������ ������������


    Public Const MAXERROR = 205


    ' ���� ����������
    Public Const lt_DocSheetStandart = 1        ' ��� ��������� 1- ������ �����������
    Public Const lt_DocSheetUser = 2            '               2- ������ �������������
    Public Const lt_DocFragment = 3             '               3- ��������
    Public Const lt_DocSpc = 4                  '               4- ������������
    Public Const lt_DocPart3D = 5               '               5- 3d-�������� ������
    Public Const lt_DocAssemble3D = 6           '               6- 3d-�������� ������
    Public Const lt_DocTxtStandart = 7          '               7- ��������� �������� �����������
    Public Const lt_DocTxtUser = 8              '               8- ��������� �������� �������������
    Public Const lt_DocSpcUser = 9              '               9- ������������ ������������� ������

    ' ���� ����� �������� ������
    Public Const txta_Left = 0   ' ����� �������� �����
    Public Const txta_Center = 1 ' ����� �������� �������
    Public Const txta_Right = 2  ' ����� �������� ������

    ' ������� ���������
    Public Const lt_qsShaft = 1    ' 1 - ����
    Public Const lt_qsHole = 2     ' 2 - ���������

    ' ���������
    Public Const lt_qdPreferable = 1  ' 1 - ����������������
    Public Const lt_qdBasic = 2       ' 2 - ��������
    Public Const lt_qdAdditional = 3  ' 3 - ��������������

    ' ���� ������ ��� LtVariant
    Public Const ltv_Char = 1    ' 1 - ������
    Public Const ltv_UChar = 2   ' 2 - ����
    Public Const ltv_Int = 3     ' 3 - �����
    Public Const ltv_UInt = 4    ' 4 - ����������� �����
    Public Const ltv_Long = 5    ' 5 - ������� �����
    Public Const ltv_Float = 6   ' 6 - ������������
    Public Const ltv_Double = 7  ' 7 - ������� ������������
    Public Const ltv_Str = 8     ' 8 - ������ 255 ��������
    Public Const ltv_NoUsed = 9  ' 9 - ���� �� ������������
    Public Const ltv_Short = 10  ' 10 - �������� �����
    Public Const ltv_WStr = 11   ' 11 - ������ 255 �������� Unicode


    Public Const TEXT_LENGTH = 128
    Public Const MAX_TEXT_LENGTH = 255

    Public Const ODBC_DB = 0
    Public Const TXT_DB = 1

    Public Const TXT_CHAR = 1
    Public Const TXT_USHORT = 2
    Public Const TXT_SSHORT = 3
    Public Const TXT_SLONG = 4
    Public Const TXT_ULONG = 5
    Public Const TXT_LONG = 6
    Public Const TXT_FLOAT = 7
    Public Const TXT_DOUBLE = 8
    Public Const TXT_INT = 9
    Public Const TXT_ALL = 0
    Public Const TXT_INDEX = "Index1000"

    Public Const stACTIVE = 0     ' ��������� ��� ����, ����, ���������
    Public Const stREADONLY = 1   ' ��������� ��� ����, ����
    Public Const stINVISIBLE = 2  ' ��������� ��� ����, ����
    Public Const stCURRENT = 3    ' ��������� ��� ����, ����
    Public Const stPASSIVE = 1    ' ��������� ��� ���������


    ' ����������� ��� ������� ksSytemPath
    Public Const sptSYSTEM_FILES = 0           ' ������ ���� �� ������� ��������� ������
    Public Const sptLIBS_FILES = 1             ' ������ ���� �� ������� ������ ���������
    Public Const sptTEMP_FILES = 2             ' ������ ���� �� ������� ���������� ��������� ������
    Public Const sptCONFIG_FILES = 3           ' ������ ���� �� ������� ���������� ������������ �������
    Public Const sptINI_FILE = 4               ' ������ ������ ��� INI-����� �������
    Public Const sptBIN_FILE = 5               ' ������ ���� �� ������� ����������� ������ �������
    Public Const sptPROJECT_FILES = 6          ' ������ ���� �� ������� ���������� kompas.prj
    Public Const sptDESKTOP_FILES = 7          ' ������ ���� �� ������� ���������� kompas.dsk
    Public Const sptTEMPLATES_FILES = 8        ' ������ ���� �� ������� �������� ������-����������
    Public Const sptPROFILES_FILES = 9         ' ������ ���� �� ������� ���������� �������� ������������
    Public Const sptWORK_FILES = 10            ' ������ ���� �� ������� "��� ���������"
    Public Const sptSHEETMETAL_FILES = 11      ' ������ ���� �� ������� ������ ������
    Public Const sptPARTLIB_FILES = 12         ' ������ ���� �� ������� PartLib
    Public Const sptMULTILINE_FILES = 13       ' ������ ���� � �������� �������� �����������
    Public Const sptPRINTDEVICE_FILES = 14     ' ������ ���� � �������� ������������ ���������/���������
    Public Const sptCURR_WORK_FILES = 15       ' ����������� ��������� �����������, � ������� ����������� ��������/���������� ����� � ������� Open|Save
    Public Const sptCURR_LIBS_FILES = 16       ' ����������� ��������� �����������, � ������� ����������� ��������/���������� ����� � ������� Open|Save
    Public Const sptCURR_SYSTEM_FILES = 17     ' ����������� ��������� �����������, � ������� ����������� ��������/���������� ����� � ������� Open|Save
    Public Const sptCURR_PROFILES_FILES = 18   ' ����������� ��������� �����������, � ������� ����������� ��������/���������� ����� � ������� Open|Save
    Public Const sptCURR_SHEETMETAL_FILES = 19 ' ����������� ��������� �����������, � ������� ����������� ��������/���������� ����� � ������� Open|Save

    ' ����������� ��� ���������� ������� SystemControlStart
    Public Const scsSTOPPED_FOR_MENU_COMMAND = 1       ' ��������� ������� ���� "���������� ������ ����������"
    Public Const scsSTOPPED_FOR_SYSTEM_STOP = 0        ' ���� �������� ������
    Public Const scsSTOPPED_FOR_ITSELF = -1            ' ����� ������� SystemControlStop ��-��� ����������
    Public Const scsSTOPPED_FOR_START_THIS_LIB = -2    ' �������������� ������� ��� ������� ��� �� ����������
    Public Const scsSTOPPED_FOR_START_ANOTHER_LIB = -3 ' �������������� ������� ��� ������� ������ ����������

    '  ����������� ��� ������� GetObjParam � SetObjParam
    '  '+'  �������� �������, ��� ������� �����������  GetObjParam � SetObjParam
    '  '+-'  �������� �������, ��� ������� ���������� ������ GetObjParam
    Public Const ALLPARAM = -1                 ' ��� ��������� ������� � ������� ��������� ���������
    Public Const SHEET_ALLPARAM = -2           ' ���� ��� �  ALLPARAM  �� ��������� ������� � �� �����
    Public Const NURBS_CLAMPED_PARAM = -5      ' ��������� ������, ������������� ������� ������ � �������
    Public Const NURBS_CLAMPED_SHEETPARAM = -6 ' ��������� ������ � �� �����, ������������� ������� ������ � �������
    Public Const VIEW_ALLPARAM = -7            ' ��� ��������� ������� � �� ����

    Public Const ANGLE_ARC_PARAM = 0          ' ��������� ���� �� ����� ( ��� ���� � ������������� ���� ) � �� ������� ���������
    Public Const POINT_ARC_PARAM = 1          ' ��������� ���� �� ������ ( ��� ���� � ������������� ���� ) � �� ������� ���������
    Public Const ANGLE_ARC_SHEET_PARAM = 2    ' ��������� ���� �� ����� ( ��� ���� � ������������� ���� ) � �� �����
    Public Const POINT_ARC_SHEET_PARAM = 3    ' ��������� ���� �� ������ ( ��� ���� � ������������� ���� ) � �� �����
    Public Const ANGLE_ARC_VIEW_PARAM = 4     ' ��������� ���� �� ����� ( ��� ���� � ������������� ���� ) � �� ����
    Public Const POINT_ARC_VIEW_PARAM = 5     ' ��������� ���� �� ������ ( ��� ���� � ������������� ���� ) � �� ����

    Public Const VIEW_LAYER_STATE = 1         ' ��������� ���� ,����
    Public Const DOCUMENT_STATE = 1           ' ��������� ���������
    Public Const DOCUMENT_SIZE = 0            ' ������ �����
    Public Const DIM_TEXT_PARAM = 0           ' ��������� ������ ��� ��������
    Public Const DIM_SOURSE_PARAM = 1         ' ��������� �������� �������
    Public Const DIM_DRAW_PARAM = 2           ' ��������� ��������� �������
    Public Const DIM_VALUE = 3                ' �������� ������� - double
    Public Const DIM_PARTS = 4                ' ������������ ����� ��� �������� struct DimensionPartsParam
    Public Const SHEET_DIM_PARTS = 5          ' ������������ ����� ��� �������� struct DimensionPartsParam � �� �����
    Public Const TECHNICAL_DEMAND_PAR = -1    ' ��������� ����������� ���������� -
    Public Const TT_FIRST_STR = 1000          ' ������ ������� ��� ��������� ��� ������ ������ �� �� �������
    Public Const CONIC_PARAM = 2              ' ��������� ��� ���������� ����������� ������� ( ��� ������� � ������������� ���� )
    Public Const SPC_TUNING_PARAM = 0         ' ��������� �������� ��� ����� ��
    Public Const HATCH_PARAM_EX = 0           ' ��������� ��������� �����������
    Public Const ASSOCIATION_VIEW_PARAM = 0   ' ��������� �������������� ����
    Public Const DIM_SOURSE_VIEWPARAM = 7     ' ��������� �������� ������� � ������ ��������� ����
    Public Const DIM_DRAW_VIEWPARAM = 8       ' ��������� ��������� ������� � ������ ��������� ����
    Public Const DIM_SOURSE_SHEETPARAM = 9    ' ��������� �������� ������� � ������ ��������� �����
    Public Const DIM_DRAW_SHEETPARAM = 10     ' ��������� ��������� ������� � ������ ��������� �����


    Public Const ALL_OBJ = 0                  ' ��� �������,����� ���������������, ������� ����� ������� � ���                    -
    Public Const LINESEG_OBJ = 1              ' �������                        +
    Public Const CIRCLE_OBJ = 2               ' ����������                     +
    Public Const ARC_OBJ = 3                  ' ����                           +
    Public Const TEXT_OBJ = 4                 ' �����                          +
    Public Const POINT_OBJ = 5                ' �����                          +
    Public Const HATCH_OBJ = 7                ' ���������                      +
    Public Const BEZIER_OBJ = 8               ' bezier ������                  +
    Public Const LDIMENSION_OBJ = 9           ' �������� ������                +
    Public Const ADIMENSION_OBJ = 10          ' ������� ������                 +
    Public Const DDIMENSION_OBJ = 13          ' ������������� ������           +
    Public Const RDIMENSION_OBJ = 14          ' ���������� ������              +
    Public Const RBREAKDIMENSION_OBJ = 15     ' ���������� ������ � �������    +
    Public Const ROUGH_OBJ = 16               ' �������������                  +
    Public Const BASE_OBJ = 17                ' ����                           +
    Public Const WPOINTER_OBJ = 18            ' ������� ����                   +
    Public Const CUT_OBJ = 19                 ' ����� �������                  +
    Public Const LEADER_OBJ = 20              ' ������� ����� �������                      +
    Public Const POSLEADER_OBJ = 21           ' ����� ������� ��� ����������� �������      +
    Public Const BRANDLEADER_OBJ = 22         ' ����� ������� ��� ����������� ���������    +
    Public Const MARKERLEADER_OBJ = 23        ' ����� ������� ��� ����������� ������������ +
    Public Const TOLERANCE_OBJ = 24           ' ������ �����                   +
    Public Const TABLE_OBJ = 25               ' �������                        +     //������
    Public Const CONTOUR_OBJ = 26             ' ������                         +     //�����
    Public Const MACRO_OBJ = 27               ' ���������������� ������������  -
    Public Const LINE_OBJ = 28                ' �����                          +
    Public Const LAYER_OBJ = 29               ' ����                           +
    Public Const FRAGMENT_OBJ = 30            ' �������� ��������              +
    Public Const POLYLINE_OBJ = 31            ' ���������                      +
    Public Const ELLIPSE_OBJ = 32             ' ������                         +
    Public Const NURBS_OBJ = 33               ' nurbs ������                   +
    Public Const ELLIPSE_ARC_OBJ = 34         ' ���� �������                   +
    Public Const RECTANGLE_OBJ = 35           ' �������������                  +
    Public Const REGULARPOLYGON_OBJ = 36      ' �������������                  +
    Public Const EQUID_OBJ = 37               ' ������������                   +
    Public Const LBREAKDIMENSION_OBJ = 38     ' �������� ������ � �������      +
    Public Const ABREAKDIMENSION_OBJ = 39     ' ������� ������ � �������       +
    Public Const ORDINATEDIMENSION_OBJ = 40   ' ������ ������
    Public Const COLORFILL_OBJ = 41           ' ������� ������� ������         +
    Public Const CENTREMARKER_OBJ = 42        ' ����������� ������             +
    Public Const ARCDIMENSION_OBJ = 43        ' ������ ����� ����
    Public Const SPC_OBJ = 44                 ' ������ ������������            +
    Public Const RASTER_OBJ = 45              ' ��������� ������               +
    Public Const CHANGE_LEADER_OBJ = 46       ' ����������� ���������          +
    Public Const REMOTE_ELEMENT_OBJ = 47      ' �������� �������               -
    Public Const AXISLINE_OBJ = 48            ' ������ �����                   +
    Public Const OLEOBJECT_OBJ = 49           ' ������� ole �������            -
    Public Const KNOTNUMBER_OBJ = 50          ' ������ ����� ����              -
    Public Const BRACE_OBJ = 51               ' ������ �������� ������         -
    Public Const POSNUM_OBJ = 52              ' �����/����������� ����������� � ������-�������� -
    Public Const MARKONLDR_OBJ = 53           ' �����/����������� ����������� �� �����          -
    Public Const MARKWOLDR_OBJ = 54           ' �����/����������� ����������� ��� �����-������� -
    Public Const WAVELINE_OBJ = 55            ' ��������� �����                -
    Public Const DIRAXIS_OBJ = 56             ' ������ ���                     -
    Public Const BROKENLINE_OBJ = 57          ' ����� ������ � ��������        -
    Public Const CIRCLEAXIS_OBJ = 58          ' �������� ���                   -
    Public Const ARCAXIS_OBJ = 59             ' ������� ���                    -
    Public Const CUTUNITMARKING = 60          ' ����������� ���� � �������     -
    Public Const UNITMARKING = 61             ' ����������� ����      -
    Public Const MULTITEXTLEADER = 62         ' �������� ������� � ������������ ������������.      -
    Public Const EXTERNALVIEW_OBJ = 63        ' ������� �������� ����                          -
    Public Const ANNLINESEG_OBJ = 64          ' ������������� �������                 +- ��� GetObjParam ������������ ��������� LineSegParam
    Public Const ANNCIRCLE_OBJ = 65           ' ������������� ����������              +- ��� GetObjParam ������������ ��������� CircleParam
    Public Const ANNELLIPSE_OBJ = 66          ' ������������� ������                  +- ��� GetObjParam ������������ ��������� EllipseParam
    Public Const ANNARC_OBJ = 67              ' ������������� ����                    +- ��� GetObjParam ������������ ��������� ArcParam
    Public Const ANNELLIPSE_ARC_OBJ = 68      ' ������������� ���� �������            +- ��� GetObjParam ������������ ��������� EllipseArcParam
    Public Const ANNPOLYLINE_OBJ = 69         ' ������������� ���������               +- ��� GetObjParam ������������ ��������� PolylineParam
    Public Const ANNPOINT_OBJ = 70            ' ������������� �����                   +- ��� GetObjParam ������������ ��������� PointParam
    Public Const ANNTEXT_OBJ = 71             ' ����� � ������������� ������ �������� +- ��� GetObjParam ������������ ��������� TextParam
    Public Const MULTILINE_OBJ = 72           ' �����������                    -
    Public Const BUILDINGCUTLINE_OBJ = 73     ' ����� �������/������� ��� ���� + ������������ ��������� CutLineParam
    Public Const ATTACHED_LEADER_OBJ = 74     ' �������������� ����� ������� ( �� ����� ������� )  +

    Public Const MAX_VIEWTIP_SEARCH = 75      ' ������� ������� ����� ������ ��� �������� ����  -

    Public Const SPECIFICATION_OBJ = 121      ' ������������ �� �����
    Public Const SPECROUGH_OBJ = 122          ' ����������� �������������      +
    Public Const VIEW_OBJ = 123               ' ���                            +
    Public Const DOCUMENT_OBJ = 124           ' ��������  �����������          +   (���� ��� ��������)
    Public Const TECHNICALDEMAND_OBJ = 125    ' ����������� ����������         +
    Public Const STAMP_OBJ = 126              ' �����                          +  //������
    Public Const SELECT_GROUP_OBJ = 127       ' ������ ��������������          -
    Public Const NAME_GROUP_OBJ = 128         ' ������� ������                 -
    Public Const WORK_GROUP_OBJ = 129         ' ������� ������                 -
    Public Const SPC_DOCUMENT_OBJ = 130       ' ��������  ������������         +
    Public Const D3_DOCUMENT_OBJ = 131        ' 3d ��������  ������ ��� ������ +
    Public Const CHANGE_LIST_OBJ = 132        ' ������� ���������              -
    Public Const TXT_DOCUMENT_OBJ = 133       ' ��������� ��������
    Public Const ALL_DOCUMENTS = 134          ' ��������� ���� �����

    Public Const MAX_TIP_SEARCH = 134         ' ������� ������� ����� ������   -
    Public Const ALL_OBJ_SHOW_ORDER = -1000   ' ��� ������� ������� ����� ������� � ��� � ������� ���������



    ' ���� ��� ����� ����� ��������( ��������� ����� ) :
    ' 1  - ��������,
    ' 2  - ������,
    ' 3  - ������,
    ' 4  - ���������,
    ' 5  - ��������� �����
    ' 6  - ���������������,
    ' 7  - ����������,
    ' 8  - �����-������� � 2 �������,
    ' 9  - ��������� �������
    ' 10 -������ �������
    ' 11 -������, ���������� � ���������
    ' 12 - ISO ��������� �����
    ' 13 - ISO ��������� ����� (��. ������)
    ' 14 - ISO ��������������� ����� (��. �����)
    ' 15 - ISO ��������������� ����� (��. ����� 2 ��������)
    ' 16 - ISO ��������������� ����� (��. ����� 3 ��������)
    ' 17 - ISO ���������� �����
    ' 18 - ISO ��������������� ����� (��. � ���. ������)
    ' 19 - ISO ��������������� ����� (��. � 2 ���. ������)
    ' 20 - ISO ��������������� �����
    ' 21 - ISO ��������������� ����� (2 ������)
    ' 22 - ISO ��������������� ����� (2 ��������)
    ' 23 - ISO ��������������� ����� (3��������)
    ' 24 - ISO ��������������� ����� (2 ������ 2 ��������)
    ' 25 - ISO ��������������� ����� (2 ������ 3 ��������)


    ' ���� ��� ����� ��� �����( ��������� ����� ) :
    ' 0 - �����
    ' 1 - �������
    ' 2 - �-�����
    ' 3 - �������
    ' 4 - �����������
    ' 5 - ����������
    ' 6 - ������
    ' 7 - ������������� �������
    ' 8 - ���������� ����

    ' ���� ��� ��������� ��� ���������( ��������� ����� ) :
    ' 0  - ������
    ' 1  - ��������
    ' 2  - ������
    ' 3  - ������ ������������
    ' 4  - ��������
    ' 5  - �����
    ' 6  - ������
    ' 7  - ��������
    ' 8  - ������������ �����
    ' 9  - �������� �����
    ' 10 - ������ �������������
    ' 11 - �����������
    ' 12 - ����������� �����������
    ' 13 - ������ � ���������� �������
    ' 14 - �����

    ' ����������� ������ ��� ������
    Public Const INVARIABLE = 0              ' �� ������ ����� ������

    Public Const NUMERATOR = &H1             ' ���������
    Public Const DENOMINATOR = &H2           ' �����������
    Public Const END_FRACTION = &H3          ' ����� �����
    Public Const UPPER_DEVIAT = &H4          ' ������� ����������
    Public Const LOWER_DEVIAT = &H5          ' ������ ����������
    Public Const END_DEVIAT = &H6            ' �����  ����������
    Public Const S_BASE = &H7                ' ��������� ��������� ���� �����
    Public Const S_UPPER_INDEX = &H8         ' ������� ������ ��������� ���� �����
    Public Const S_LOWER_INDEX = &H9         ' ������ ������ ��������� ���� �����
    Public Const S_END = &H10                ' ����� ��������� ���� �����
    Public Const SPECIAL_SYMBOL = &H11       ' ��������
    Public Const SPECIAL_SYMBOL_END = &H12   ' ��� ���������� � �������
    Public Const RETURN_BEGIN = &H13         ' ������ ��� ����� ��������� ����� � ��������� � �������, ������, �����������
    Public Const RETURN_DOWN = &H14          ' ��� ����� ��������� ����� � ��������� � �������, ������, �����������
    Public Const RETURN_RIGHT = &H15         ' ��� ����� ����� ������ � ��������� � �������, ������, �����������
    Public Const TAB_ = &H16                 ' ��������� �� �������� �����
    Public Const FONT_SYMBOL = &H17          ' ������ �����
    Public Const FONT_SYMBOL_W = &O2017      ' ������ ����� Unicode
    Public Const HYPER_TEXT = &O2000         ' ������ �� ����� ��� ��������� �������

    Public Const ITALIC_ON = &H40        ' �������� ������
    Public Const ITALIC_OFF = &H80       ' �������� ������
    Public Const BOLD_ON = &H100         ' �������� �������
    Public Const BOLD_OFF = &H200        ' �������� �������
    Public Const UNDERLINE_ON = &H400    ' �������� �������������
    Public Const UNDERLINE_OFF = &H800   ' �������� �������������
    Public Const NEW_LINE = &H1000       ' ����� ������ � ���������

    Public Const FONT_NAME = 1               '  ��� �����
    Public Const NARROWIN = 2               '  ����������� ������� ����� "���� ���������� NARROWING"
    Public Const HEIGHT = 3                  '  ������ �����
    Public Const COLOR = 4                   '  ���� ������
    Public Const SPECIAL = 5                 '  ��������
    Public Const FRACTION_TYPE = 6           '  ������ ����� �� ��������� � ������ 1-������ ������ 2-� 1.5 ���� ������ 3-� 2 ���� ������
    Public Const SUM_TYPE = 7                '  ������ ��������� ���� ����� �� ��������� � ������ 1-������ ������ 2-� 1.5 ���� ������

    ' ���� style ��� ������( ��������� ����� ) :
    ' 0 -������������� ����� ��� ������� ���� �������
    ' 1  ����� �� �������
    ' 2  ����� ��� ����������� ����������
    ' 3  ����� ��������� ��������
    ' 4  ����� �������������
    ' 5  ����� ��� ����� �������  ( ����������� )
    ' 6  ����� ��� ����� �������  ( ���\��� ������ )
    ' 7  ����� ��� ����� �������  ( ����� )
    ' 8  ����� ��� ������� �����
    ' 9  ����� ��� ������� ( ��������� )
    ' 10 ����� ��� ������� ( ������ )
    ' 11 ����� ��� ����� �������
    ' 12 ����� ��� ������� ����
    ' 13 ����� ��� ��� ����������� �������������
    ' 14 ����� ��� ����������� ���������
    ' 15 ����� ��� �������� ������
    ' 16 ����� ��� ������ ����
    ' 17 ����� ��� �������� �������
    ' 18 ����� ��� ����������� ����
    ' 19 ����� ��� ����� ��������������� ���
    ' 20 ����� ��� ���(�����/����������� ����������� � ������-��������)
    ' 21 ����� ��� ���(�����/����������� �����������) �� �����
    ' 22 ����� ��� ���(�����/����������� �����������) ��� ����� �������
    ' 23 ����� ��� ���������� ������������


    ' ***************************************************************/
    ' * ��������� ��� ������ � ���������� ����������  */
    ' ***************************************************************/
    Public Const CHAR_ATTR_TYPE = 1
    Public Const UCHAR_ATTR_TYPE = 2
    Public Const INT_ATTR_TYPE = 3
    Public Const UINT_ATTR_TYPE = 4
    Public Const LINT_ATTR_TYPE = 5
    Public Const FLOAT_ATTR_TYPE = 6
    Public Const DOUBLE_ATTR_TYPE = 7
    Public Const STRING_ATTR_TYPE = 8    ' ������ ������������� ����� MAX_TEXT_LENGTH
    Public Const RECORD_ATTR_TYPE = 9

    ' ����������� ��� ��������� �������
    Public Const AUTONOMINAL = &H1         ' >0 ����������� ������� ��������������
    Public Const RECTTEXT = &H2            ' >0 ����� � �������
    Public Const PREFIX = &H4              ' >0 ���� ����� �� ��������
    Public Const NOMINALOFF = &H8          ' >0 ���  ��������
    Public Const TOLERANCE = &H10          ' >0 �������� �����������
    Public Const DEVIATION = &H20          ' >0 ���������� �����������
    Public Const UNIT = &H40               ' >0 ������� ���������
    Public Const SUFFIX = &H80             ' >0 ���� ����� ����� ��������
    Public Const DEVIATION_INFORM = &H100  ' >0 ��� ���������� _DEVIATION, ���������� ���� � ������� �������( ���� ���� �� ������ ������������ ����������).
    '    ���������� �����  ������� GetObjParam, ����� ������������ ��� �������� ����������.
    Public Const UNDER_LINE = &H200        ' >0 ������ � ��������������
    Public Const BRACKETS = &H400          ' >0 ������ � �������
    Public Const SQUARE_BRACKETS = &H800   ' >0 ������ � ���������� �������, ������������ ������ � _BRACKETS
    '  BRACKETS                    - ������ � ������� �������
    '  BRACKETS | _SQUARE_BRACKETS - ������ � ���������� �������

    Public Const INDICATIN_TEXT_LINE_ARR = &HFFFF    ' ��� �������������, ����������� ����� �������, ���������� � ���������
    ' �������, ��� ��� ������ ������������ ������������ ������ TEXT_LINE_ARR

    ' ���� ������
    Public Const CURVE_STYLE = 1     ' ����� �������
    Public Const HATCH_STYLE = 2     ' ����� ���������
    Public Const TEXT_STYLE = 3      ' ����� ������
    Public Const STAMP_STYLE = 4     ' ����� ������
    Public Const CURVE_STYLE_EX = 5  ' ����� ������� �����������

    ' curveType
    Public Const LIKE_BASIC_LINE = &H10 ' ��������� ���� ��� �  �������� �����
    Public Const LIKE_THIN_LINE = &H20  ' ��������� ���� ��� �  ������ �����
    Public Const LIKE_HEAVY_LINE = &H30 ' ��������� ���� ��� �  ���������� �����

    ' ����������� ��� ������� GetSysOptions �  SetSysOptions
    Public Const DIMENTION_OPTIONS = 1          ' ��������� �������
    Public Const SNAP_OPTIONS = 1               ' ��������� ��������
    Public Const ARROWFILLING_OPTIONS = 2       ' ��������� ������� ?
    Public Const SHEET_OPTIONS = 3              ' ��������� �����
    Public Const SHEET_OPTIONS_EX = 4           ' ��������� ����� ���������
    Public Const LENGTHUNITS_OPTIONS = 5        ' ��������� ������ ���������
    Public Const SNAP_OPTIONS_EX = 6            ' ��������� �������� ���������
    Public Const VIEWCOLOR_OPTIONS = 7          ' ��������� ����� ���� �������� ���� 2d - ����������
    Public Const TEXTEDIT_VIEWCOLOR_OPTIONS = 8 ' ��������� ����� ���� �������������� ������
    Public Const MODEL_VIEWCOLOR_OPTIONS = 9    ' ��������� ����� ���� ��� �������
    Public Const OVERLAP_OBJECT_OPTIONS = 10    ' ��������� ��������������� ��������
    Public Const DIMENTION_OPTIONS_EX = 11      ' ��������� �������

    ' ���� ������� ��� ������������
    Public Const SPC_CLM_FORMAT = 1     '  ������
    Public Const SPC_CLM_ZONE = 2       '  ����
    Public Const SPC_CLM_POS = 3        '  �������
    Public Const SPC_CLM_MARK = 4       '  �����������
    Public Const SPC_CLM_NAME = 5       '  ������������
    Public Const SPC_CLM_COUNT = 6      '  ����������
    Public Const SPC_CLM_NOTE = 7       '  ����������
    Public Const SPC_CLM_MASSA = 8      '  �����
    Public Const SPC_CLM_MATERIAL = 9   '  ��������
    Public Const SPC_CLM_USER = 10      '  ����������������
    Public Const SPC_CLM_KOD = 11       '  ���
    Public Const SPC_CLM_FACTORY = 12   '  ����� ������������

    ' ���� �������� ��� ������� ������������
    Public Const SPC_INT = 1        ' �����
    Public Const SPC_DOUBLE = 2     ' ������������
    Public Const SPC_STRING = 3     ' ������
    Public Const SPC_RECORD = 4     ' ������

    ' ���� ������� ������
    Public Const CURVE_STYLE_LIBRARY = 1              ' ���������� ������ ������ (*.lcs)
    Public Const HATCH_STYLE_LIBRARY = 2              ' ���������� ������ ��������� (*.lhs)
    Public Const TEXT_STYLE_LIBRARY = 3               ' ���������� ������ �������   (*.lts)
    Public Const STAMP_LAYOUT_STYLE_LIBRARY = 4       ' ���������� ������ �������� ������� (*.lyt)
    Public Const GRAPHIC_LAYOUT_STYLE_LIBRARY = 5     ' ���������� ������ ���������� ����������� ���������� (*.lyt)
    Public Const TEXT_LAYOUT_STYLE_LIBRARY = 6        ' ���������� ������ ���������� ��������� ���������� (*.lyt)
    Public Const SPC_LAYOUT_STYLE_LIBRARY = 7         ' ���������� ������ ���������� ������������ (*.lyt)

    ' ����������� � ���� ������ ��� �������� �����-����������� �������������
    Public Const ST_MIX_MM = &H1       ' ����������
    Public Const ST_MIX_SM = 0         ' ����������
    Public Const ST_MIX_DM = &H2       ' ���������
    Public Const ST_MIX_M = &H3        ' �����
    Public Const ST_MIX_GR = 0         ' ������
    Public Const ST_MIX_KG = &H10      ' ����������
    Public Const ST_MIX_EXT = 0        ' ������������
    Public Const ST_MIX_RV = &H20      ' ��������

    ' ��� ��������� ��������
    Public Const SN_NEAREST_POINT = 1     ' ��������� �����
    Public Const SN_NEAREST_MIDDLE = 2    ' ��������
    Public Const SN_CENTRE = 3            ' �����
    Public Const SN_INTERSECT = 4         ' �����������
    Public Const SN_GRID = 5              ' �� �����
    Public Const SN_XY_ALIGN = 6          ' ������������
    Public Const SN_ANGLE = 7             ' ������� ��������
    Public Const SN_POINT_CURVE = 8       ' ����� �� ������

    ' ���� ����� �������� ��� ��������
    Public Const SN_DYNAMICALLY = &H1       ' �������� ����������� �����������
    Public Const SN_ASSISTANT = &H2         ' ������ �����
    Public Const SN_BACKGROUND_LAYER = &H4  ' ��������� ������� ���� � ����
    Public Const SN_SUSPENDED = &H8         ' �������� ��������


    ' ���� ��������������� �����������
    Public Const CONSTRAINT_FIXED_POINT = 1            ' ����������� �����
    Public Const CONSTRAINT_POINT_ON_CURVE = 2         ' ����� �� ������
    Public Const CONSTRAINT_HORIZONTAL = 3             ' �����������
    Public Const CONSTRAINT_VERTICAL = 4               ' ���������
    Public Const CONSTRAINT_PARALLEL = 5               ' �������������� ���� ������ ��� ��������
    Public Const CONSTRAINT_PERPENDICULAR = 6          ' ������������������ ���� ������ ��� ��������
    Public Const CONSTRAINT_EQUAL_LENGTH = 7           ' ��������� ���� ���� ��������
    Public Const CONSTRAINT_EQUAL_RADIUS = 8           ' ��������� �������� ���� ���/�����������
    Public Const CONSTRAINT_HOR_ALIGN_POINTS = 9       ' ����������� ��� ����� �� �����������
    Public Const CONSTRAINT_VER_ALIGN_POINTS = 10      ' ����������� ��� ����� �� ���������
    Public Const CONSTRAINT_MERGE_POINTS = 11          ' ���������� ���� �����
    Public Const CONSTRAINT_TANGENT_TWO_CURVES = 15    ' ������� ���� ������
    Public Const CONSTRAINT_SYMMETRY_TWO_POINTS = 16   ' �������� ���� �����
    Public Const CONSTRAINT_COLLINEAR = 17             ' ������������� ��������
    Public Const CONSTRAINT_FIXED_ANGLE = 18           ' ������������� ����
    Public Const CONSTRAINT_FIXED_LENGHT = 19          ' ������������� �����
    Public Const CONSTRAINT_POINT_ON_CURVE_MIDDLE = 20 ' ����� �� �������� ������
    Public Const CONSTRAINT_BISECTOR = 21              ' �����������


    ' ���� �������� ������������
    Public Const SPC_BASE_OBJECT = 1       ' ������� ������ (������������� �������������)
    Public Const SPC_COMMENT = 2           ' �����������    (������������� �������������)
    Public Const SPC_SECTION_NAME = 3      ' ������������ ������� ( ��������� �� ����� �� ������������� )
    Public Const SPC_BLOCK_NAME = 4        ' ������������ ����� ���������� ( ��������� �� ����� �� ������������� )
    Public Const SPC_RESERVE_STR = 5       ' ��������� ������ ( ��������� �� ����� �� ������������� )
    Public Const SPC_EMPTY_STR = 6         ' ������ ������ ( ��������� �� ����� �� ������������� )

    ' ���� ����������
    Public Const SPC_SORT_OFF = 0        ' ��� ����������
    Public Const SPC_SORT_COMPOS = 1     ' ��������� ����������
    Public Const SPC_SORT_ALPHABET = 2   ' ���������� �� ��������
    Public Const SPC_SORT_UP = 3         ' ���������� �� ����������� �������
    Public Const SPC_SORT_DOCUMENT = 4   ' ���������� ������� ������������
    Public Const SPC_SORT_DOWN = 5       ' ���������� �� �������� �������
    Public Const SPC_SORT_COMPOSDOWN = 6 ' ��������� ���������� �� ��������

    ' //////////////////////////////////////////////////////////////////////////////
    '
    '  ���� ����������� �������� ( ������������� ������ )
    '
    ' //////////////////////////////////////////////////////////////////////////////
    Public Const ARROW_INSIDE_SYMBOL = 1          ' ������� �������
    Public Const ARROW_OUT_SIDE_SYMBOL = 2        ' ������� �������
    Public Const TICK_TAIL_SYMBOL = 3             ' ������� � ������������ ������ (� ���������)
    Public Const UP_HALF_ARROW_SYMBOL = 4         ' ������� �������� ������� �������
    Public Const DOWN_HALF_ARROW_SYMBOL = 5       ' ������ �������� ������� �������
    Public Const BIG_ARROW_INSIDE_SYMBOL = 6      ' ������� ������� ������� (7��)
    Public Const ARROW_ORDINATE_DIM_SYMBOL = 7    ' ������� ��� ������� ������(������ ������ 4 �� ��� ����� 45 ��)
    Public Const TRIANGLE_SYMBOL = 8              ' ����������� �� ����-��� ������
    Public Const CIRCLE_RAD2_SYMBOL = 9           ' ���������� �������� 2 �� ������ ������ - ��� ���-��� � �����-�������
    Public Const CENTRE_MARKER_SYMBOL = 10        ' ����������� ���������� ������ � ���� �������� ������
    Public Const GLUE_SIGN_SYMBOL = 11            ' ���� ����������
    Public Const SOLDER_SIGN_SYMBOL = 12          ' ���� �����
    Public Const SEWING_SIGN_SYMBOL = 13          ' ���� ��������
    Public Const CRAMP_SIGN_SYMBOL = 14           ' ���� ���������� ���������� ������.�������
    Public Const CORNER_CRAMP_SIGN_SYMBOL = 15    ' ���� �������� ���������� ������.�������
    Public Const MONTAGE_JOINT_SYMBOL = 16        ' ���� ���������� ���
    Public Const TICK_SYMBOL = 17                 ' ������� ��� ����������� ������ (��� ��������)
    Public Const TRIANGLE_CURR_CS = 18            ' ����������� �� ������� �� - ��� ����
    Public Const ARROW_CLOSED_INSIDE = 19         ' �������� ������� �������
    Public Const ARROW_CLOSED_OUTSIDE = 20        ' �������� ������� �������
    Public Const ARROW_OPEN_INSIDE = 21           ' �������� ������� �������
    Public Const ARROW_OPEN_OUTSIDE = 22          ' �������� ������� �������
    Public Const ARROW_RIGHTANGLE_INSIDE = 23     ' ������� 90 ���� �������
    Public Const ARROW_RIGHTANGLE_OUTSIDE = 24    ' ������� 90 ���� �������
    Public Const SYMBOL_DOT = 25                  ' ����� (������� ����� ����� ������� �������)
    Public Const SYMBOL_SMALLDOT = 26             ' ����� ��������� (������� ����� 0.6 ����� ������� �������)
    Public Const AUXILIARY_POINT = 27             ' ��������������� �����
    Public Const LEFT_TICK_SYMBOL = 28            ' ������� � �������� �����

    ' ���� ���������������� ������������ ��������
    Public Const CHAR_STR_ARR = 1            ' ������������ ������ ���������� �� ������ ��������
    Public Const POINT_ARR = 2               ' ������������ ������ ���������� �� �������������� ����� -��������� MathPointParam
    Public Const CURVE_PATTERN_ARR = 2       ' ������������ ������ ���������� �� ������� ��������� ����� -��������� CurvePattern
    Public Const TEXT_LINE_ARR = 3           ' ������������ ������ ����� ������ - ��������� TextLineParam
    Public Const TEXT_ITEM_ARR = 4           ' ������������ ������ ��������� ����� ������ ��������� TextItemParam
    Public Const ATTR_COLUMN_ARR = 5         ' ������������ ������ ������� ����������- ���������  ColumnInfo
    Public Const USER_ARR = 6                ' ������������ ���������������� ������
    Public Const POLYLINE_ARR = 7            ' ������������ ������ ���������-(���������� �������� POINT_ARR)
    Public Const RECT_ARR = 8                ' ������������ ������ ���������� ���������������-(��������� RectParam)
    Public Const LIBRARY_STYLE_ARR = 9       ' ������������ ������ �������� ���������� ��� ����� � ���������� ������( LibraryStyleParam )
    Public Const VARIABLE_ARR = 10           ' ������������ ������ �������� ���������� ��������������� ����������( VariableParam )
    Public Const CURVE_PATTERN_ARR_EX = 11   ' ������������ ������ ���������� �� ������� ��������� ����� -��������� CurvePatternEx
    Public Const LIBRARY_ATTR_TYPE_ARR = 12  ' ������������ ������ �������� ���������� ��� ���� �������� � ���������� ����� ���������( LibraryAttrTypeParam )
    Public Const NURBS_POINT_ARR = 13        ' ������������ ������ �������� NurbsPointParam
    Public Const DOUBLE_ARR = 14             ' ������������ ������ duuble
    Public Const CONSTRAIN_ARR = 15          ' ������������ ������ ��������������� ����������� - ��������� ConstrainParam
    Public Const CORNER_ARR = 16             ' ������������ ������ �������� ���������� ����� CornerParam ��� ��������������� � ���������������
    Public Const DOC_SPCOBJ_ARR = 17         ' ������������ ������ �������� ���������� ������������� ���������� � ������� ������������
    Public Const SPCSUBSECTION_ARR = 18      ' ������������ ������ �������� ���������� ���������� ������������ SpcSubSectionParam
    Public Const SPCTUNINGSEC_ARR = 19       ' ������������ ������ �������� ���������� ��������� ������� ������������ SpcTuningSectionParam
    Public Const SPCSTYLECOLUMN_ARR = 20     ' ������������ ������ �������� ���������� ����� ������� ������� ������������ SpcStyleColumnParam
    Public Const SPCSTYLESEC_ARR = 21        ' ������������ ������ �������� ���������� ����� ������a ������������ SpcStyleSectionParam
    Public Const QUALITYITEM_ARR = 22        ' ������������ ������ �������� QualityItemParam - ������ �� ����� ��������� ��� ������-�� ���������
    Public Const LTVARIANT_ARR = 23          ' ������������ ������ �������� LtVariant
    Public Const TOLERANCEBRANCH_ARR = 24    ' ������������ ������ �������� ToleranceBranch
    Public Const HATCHLINE_ARR = 25          ' ������������ ������ �������� HatchLineParam
    Public Const TREENODEPARAM_ARR = 26      ' ������������ ������ �������� ���� ������ TreeNodeParam

    '-----------------------------------------------------------------------------
    ' ����������� ��� ����������� � ��������� ������
    ' ---
    Public Const FORMAT_BMP = 0
    Public Const FORMAT_GIF = 1
    Public Const FORMAT_JPG = 2
    Public Const FORMAT_PNG = 3
    Public Const FORMAT_TIF = 4
    Public Const FORMAT_TGA = 5
    Public Const FORMAT_PCX = 6
    Public Const FORMAT_WMF = 16
    Public Const FORMAT_EMF = 17

    '-----------------------------------------------------------------------------
    ' ����������� ��� ��������� ����� ���������� �������
    ' ---
    Public Const BLACKWHITE = 0    ' ���� ������
    Public Const COLORVIEW = 1     ' ���� ������������� ��� ����
    Public Const COLORLAYER = 2    ' ���� ������������� ��� ����
    Public Const COLOROBJECT = 3   ' ���� ������������� ��� �������

    '-----------------------------------------------------------------------------
    ' ����������� ��� �� ������ ��� ����������� � ��������� ������
    ' ---
    Public Const BPP_COLOR_01 = 1   ' "������"
    Public Const BPP_COLOR_02 = 2   ' "4 �����"
    Public Const BPP_COLOR_04 = 4   ' "16 ������"
    Public Const BPP_COLOR_08 = 8   ' "256 ������"
    Public Const BPP_COLOR_16 = 16  ' "16 ��������"
    Public Const BPP_COLOR_24 = 24  ' "24 �������"
    Public Const BPP_COLOR_32 = 32  ' "32 �������"

    '-----------------------------------------------------------------------------
    ' ������������ ��������� ����� ���� ������ ���������� ����������  LtNodeType
    ' ---
    Public Const tn_root = 0  ' ������ ������
    Public Const tn_dir = 1   ' ����� (����������)
    Public Const tn_file = 2  ' �������� (����)

    '------------------------------------------------------------------------------
    ' ���� ����������� �����
    ' ---
    Public Const VIEW_FRONT = &H1  ' �������
    Public Const VIEW_REAR = &H2   ' �����
    Public Const VIEW_UP = &H4     ' ������
    Public Const VIEW_DOWN = &H8   ' �����
    Public Const VIEW_LEFT = &H10  ' �����
    Public Const VIEW_RIGHT = &H20 ' ������
    Public Const VIEW_ISO = &H40   ' ���������

    '------------------------------------------------------------------------------
    ' ���� ������ ������� "�������� �������" LtRemoteElmSignType
    ' ---
    Public Const re_Circle = 0    ' ����������
    Public Const re_Rectangle = 1 ' �������������
    Public Const re_Ballon = 2    ' ����������� �������������

    '------------------------------------------------------------------------------
    ' ��� ��������� ������� �������� ChangeOrderType
    ' ---
    Public Const co_Top = 1          ' ���� ����
    Public Const co_Bottom = 2       ' ���� ����
    Public Const co_BeforeObject = 3 ' ����� ��������
    Public Const co_AfterObject = 4  ' �� ��������
    Public Const co_UpLevel = 5      ' �� ������� ������
    Public Const co_DownLevel = 6    ' �� ������� �����

    '------------------------------------------------------------------------------
    ' ���������� ������� ������
    ' ---
    Public Const OCR_SELECT = &HFFFE ' ������ ����� SELECT
    Public Const OCR_SNAP = &HFFFD   ' ������ ����� SNAP
    Public Const OCR_CATCH = &HFFFC  ' ������ ����� CATCH
    Public Const OCR_DEDAULT = 0     ' ������ � ���� ������

    '-----------------------------------------------------------------------------
    ' �������������� ���� ��� TextItemFont.color
    ' � ����� ����� ���� ��������� �� ��������� ���� �������� �� 0
    ' � ���� ������ ���� TextItemFont.color ����� �������� 0 �� ���������
    ' ����������� �� ���� � �� �� ����� ������������ ��� ���� �� ���������
    ' ��� ���� ����� ����������� ����� �� �������� �����
    ' ��� �������� ���� �� �������� ��� ��������� FREE_COLOR
    ' ---
    Public Const FREE_COLOR = &HFF000000      '  �������������� ����


End Module