using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Message_Handler_Generator
{
    public partial class MainForm : Form
    {
        private Hashtable ht = new Hashtable();
 
        public MainForm()
        {
            InitializeComponent();

            #region Initialize HashTable
            ht["WM_COMPACTING"] = "void Cls_OnCompacting(HWND hwnd, UINT compactRatio)";
            ht["WM_WININICHANGE"] = "void Cls_OnWinIniChange(HWND hwnd, LPCTSTR lpszSectionName)";
            ht["WM_SYSCOLORCHANGE"] = "void Cls_OnSysColorChange(HWND hwnd)";
            ht["WM_QUERYNEWPALETTE"] = "BOOL Cls_OnQueryNewPalette(HWND hwnd)";
            ht["WM_PALETTEISCHANGING"] = "void Cls_OnPaletteIsChanging(HWND hwnd, HWND hwndPaletteChange)";
            ht["WM_PALETTECHANGED"] = "void Cls_OnPaletteChanged(HWND hwnd, HWND hwndPaletteChange)";
            ht["WM_FONTCHANGE"] = "void Cls_OnFontChange(HWND hwnd)";
            ht["WM_SPOOLERSTATUS"] = "void Cls_OnSpoolerStatus(HWND hwnd, UINT status, int cJobInQueue)";
            ht["WM_DEVMODECHANGE"] = "void Cls_OnDevModeChange(HWND hwnd, LPCTSTR lpszDeviceName)";
            ht["WM_TIMECHANGE"] = "void Cls_OnTimeChange(HWND hwnd)";
            ht["WM_POWER"] = "void Cls_OnPower(HWND hwnd, int code)";
            ht["WM_QUERYENDSESSION"] = "BOOL Cls_OnQueryEndSession(HWND hwnd)";
            ht["WM_ENDSESSION"] = "void Cls_OnEndSession(HWND hwnd, BOOL fEnding)";
            ht["WM_QUIT"] = "void Cls_OnQuit(HWND hwnd, int exitCode)";
            ht["WM_SYSTEMERROR"] = "void Cls_OnSystemError(HWND hwnd, int errCode)";
            ht["WM_CREATE"] = "BOOL Cls_OnCreate(HWND hwnd, LPCREATESTRUCT lpCreateStruct)";
            ht["WM_NCCREATE"] = "BOOL Cls_OnNCCreate(HWND hwnd, LPCREATESTRUCT lpCreateStruct)";
            ht["WM_DESTROY"] = "void Cls_OnDestroy(HWND hwnd)";
            ht["WM_NCDESTROY"] = "void Cls_OnNCDestroy(HWND hwnd)";
            ht["WM_SHOWWINDOW"] = "void Cls_OnShowWindow(HWND hwnd, BOOL fShow, UINT status)";
            ht["WM_SETREDRAW"] = "void Cls_OnSetRedraw(HWND hwnd, BOOL fRedraw)";
            ht["WM_ENABLE"] = "void Cls_OnEnable(HWND hwnd, BOOL fEnable)";
            ht["WM_SETTEXT"] = "void Cls_OnSetText(HWND hwnd, LPCTSTR lpszText)";
            ht["WM_GETTEXT"] = "INT Cls_OnGetText(HWND hwnd, int cchTextMax, LPTSTR lpszText)";
            ht["WM_GETTEXTLENGTH"] = "INT Cls_OnGetTextLength(HWND hwnd)";
            ht["WM_WINDOWPOSCHANGING"] = "BOOL Cls_OnWindowPosChanging(HWND hwnd, LPWINDOWPOS lpwpos)";
            ht["WM_WINDOWPOSCHANGED"] = "void Cls_OnWindowPosChanged(HWND hwnd, const LPWINDOWPOS lpwpos)";
            ht["WM_MOVE"] = "void Cls_OnMove(HWND hwnd, int x, int y)";
            ht["WM_SIZE"] = "void Cls_OnSize(HWND hwnd, UINT state, int cx, int cy)";
            ht["WM_CLOSE"] = "void Cls_OnClose(HWND hwnd)";
            ht["WM_QUERYOPEN"] = "BOOL Cls_OnQueryOpen(HWND hwnd)";
            ht["WM_GETMINMAXINFO"] = "void Cls_OnGetMinMaxInfo(HWND hwnd, LPMINMAXINFO lpMinMaxInfo)";
            ht["WM_PAINT"] = "void Cls_OnPaint(HWND hwnd)";
            ht["WM_ERASEBKGND"] = "BOOL Cls_OnEraseBkgnd(HWND hwnd, HDC hdc)";
            ht["WM_ICONERASEBKGND"] = "BOOL Cls_OnIconEraseBkgnd(HWND hwnd, HDC hdc)";
            ht["WM_NCPAINT"] = "void Cls_OnNCPaint(HWND hwnd, HRGN hrgn)";
            ht["WM_NCCALCSIZE"] = "UINT Cls_OnNCCalcSize(HWND hwnd, BOOL fCalcValidRects, NCCALCSIZE_PARAMS * lpcsp)";
            ht["WM_NCHITTEST"] = "UINT Cls_OnNCHitTest(HWND hwnd, int x, int y)";
            ht["WM_QUERYDRAGICON"] = "HICON Cls_OnQueryDragIcon(HWND hwnd)";
            ht["WM_DROPFILES"] = "void Cls_OnDropFiles(HWND hwnd, HDROP hdrop)";
            ht["WM_ACTIVATE"] = "void Cls_OnActivate(HWND hwnd, UINT state, HWND hwndActDeact, BOOL fMinimized)";
            ht["WM_ACTIVATEAPP"] = "void Cls_OnActivateApp(HWND hwnd, BOOL fActivate, DWORD dwThreadId)";
            ht["WM_NCACTIVATE"] = "BOOL Cls_OnNCActivate(HWND hwnd, BOOL fActive, HWND hwndActDeact, BOOL fMinimized)";
            ht["WM_SETFOCUS"] = "void Cls_OnSetFocus(HWND hwnd, HWND hwndOldFocus)";
            ht["WM_KILLFOCUS"] = "void Cls_OnKillFocus(HWND hwnd, HWND hwndNewFocus)";
            ht["WM_KEYDOWN"] = "void Cls_OnKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags)";
            ht["WM_KEYUP"] = "void Cls_OnKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags)";
            ht["WM_CHAR"] = "void Cls_OnChar(HWND hwnd, TCHAR ch, int cRepeat)";
            ht["WM_DEADCHAR"] = "void Cls_OnDeadChar(HWND hwnd, TCHAR ch, int cRepeat)";
            ht["WM_SYSKEYDOWN"] = "void Cls_OnSysKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags)";
            ht["WM_SYSKEYUP"] = "void Cls_OnSysKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags)";
            ht["WM_SYSCHAR"] = "void Cls_OnSysChar(HWND hwnd, TCHAR ch, int cRepeat)";
            ht["WM_SYSDEADCHAR"] = "void Cls_OnSysDeadChar(HWND hwnd, TCHAR ch, int cRepeat)";
            ht["WM_MOUSEMOVE"] = "void Cls_OnMouseMove(HWND hwnd, int x, int y, UINT keyFlags)";
            ht["WM_LBUTTONDOWN"] = "void Cls_OnLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags)";
            ht["WM_LBUTTONDBLCLK"] = "void Cls_OnLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags)";
            ht["WM_LBUTTONUP"] = "void Cls_OnLButtonUp(HWND hwnd, int x, int y, UINT keyFlags)";
            ht["WM_RBUTTONDOWN"] = "void Cls_OnRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags)";
            ht["WM_RBUTTONDBLCLK"] = "void Cls_OnRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags)";
            ht["WM_RBUTTONUP"] = "void Cls_OnRButtonUp(HWND hwnd, int x, int y, UINT flags)";
            ht["WM_MBUTTONDOWN"] = "void Cls_OnMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags)";
            ht["WM_MBUTTONDBLCLK"] = "void Cls_OnMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags)";
            ht["WM_MBUTTONUP"] = "void Cls_OnMButtonUp(HWND hwnd, int x, int y, UINT flags)";
            ht["WM_MOUSEWHEEL"] = "void Cls_OnMouseWheel(HWND hwnd, int xPos, int yPos, int zDelta, UINT fwKeys)";
            ht["WM_NCMOUSEMOVE"] = "void Cls_OnNCMouseMove(HWND hwnd, int x, int y, UINT codeHitTest)";
            ht["WM_NCLBUTTONDOWN"] = "void Cls_OnNCLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest)";
            ht["WM_NCLBUTTONDBLCLK"] = "void Cls_OnNCLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest)";
            ht["WM_NCLBUTTONUP"] = "void Cls_OnNCLButtonUp(HWND hwnd, int x, int y, UINT codeHitTest)";
            ht["WM_NCRBUTTONDOWN"] = "void Cls_OnNCRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest)";
            ht["WM_NCRBUTTONDBLCLK"] = "void Cls_OnNCRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest)";
            ht["WM_NCRBUTTONUP"] = "void Cls_OnNCRButtonUp(HWND hwnd, int x, int y, UINT codeHitTest)";
            ht["WM_NCMBUTTONDOWN"] = "void Cls_OnNCMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest)";
            ht["WM_NCMBUTTONDBLCLK"] = "void Cls_OnNCMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest)";
            ht["WM_NCMBUTTONUP"] = "void Cls_OnNCMButtonUp(HWND hwnd, int x, int y, UINT codeHitTest)";
            ht["WM_MOUSEACTIVATE"] = "int Cls_OnMouseActivate(HWND hwnd, HWND hwndTopLevel, UINT codeHitTest, UINT msg)";
            ht["WM_CANCELMODE"] = "void Cls_OnCancelMode(HWND hwnd)";
            ht["WM_TIMER"] = "void Cls_OnTimer(HWND hwnd, UINT id)";
            ht["WM_INITMENU"] = "void Cls_OnInitMenu(HWND hwnd, HMENU hMenu)";
            ht["WM_INITMENUPOPUP"] = "void Cls_OnInitMenuPopup(HWND hwnd, HMENU hMenu, UINT item, BOOL fSystemMenu)";
            ht["WM_MENUSELECT"] = "void Cls_OnMenuSelect(HWND hwnd, HMENU hmenu, int item, HMENU hmenuPopup, UINT flags)";
            ht["WM_MENUCHAR"] = "DWORD Cls_OnMenuChar(HWND hwnd, UINT ch, UINT flags, HMENU hmenu)";
            ht["WM_COMMAND"] = "void Cls_OnCommand(HWND hwnd, int id, HWND hwndCtl, UINT codeNotify)";
            ht["WM_HSCROLL"] = "void Cls_OnHScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos)";
            ht["WM_VSCROLL"] = "void Cls_OnVScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos)";
            ht["WM_CUT"] = "void Cls_OnCut(HWND hwnd)";
            ht["WM_COPY"] = "void Cls_OnCopy(HWND hwnd)";
            ht["WM_PASTE"] = "void Cls_OnPaste(HWND hwnd)";
            ht["WM_CLEAR"] = "void Cls_OnClear(HWND hwnd)";
            ht["WM_UNDO"] = "void Cls_OnUndo(HWND hwnd)";
            ht["WM_RENDERFORMAT"] = "HANDLE Cls_OnRenderFormat(HWND hwnd, UINT fmt)";
            ht["WM_RENDERALLFORMATS"] = "void Cls_OnRenderAllFormats(HWND hwnd)";
            ht["WM_RENDERALLFORMATS"] = "void Cls_OnDestroyClipboard(HWND hwnd)";
            ht["WM_DRAWCLIPBOARD"] = "void Cls_OnDrawClipboard(HWND hwnd)";
            ht["WM_PAINTCLIPBOARD"] = "void Cls_OnPaintClipboard(HWND hwnd, HWND hwndCBViewer, const LPPAINTSTRUCT lpPaintStruct)";
            ht["WM_SIZECLIPBOARD"] = "void Cls_OnSizeClipboard(HWND hwnd, HWND hwndCBViewer, const LPRECT lprc)";
            ht["WM_VSCROLLCLIPBOARD"] = "void Cls_OnVScrollClipboard(HWND hwnd, HWND hwndCBViewer, UINT code, int pos)";
            ht["WM_HSCROLLCLIPBOARD"] = "void Cls_OnHScrollClipboard(HWND hwnd, HWND hwndCBViewer, UINT code, int pos)";
            ht["WM_ASKCBFORMATNAME"] = "void Cls_OnAskCBFormatName(HWND hwnd, int cchMax, LPTSTR rgchName)";
            ht["WM_CHANGECBCHAIN"] = "void Cls_OnChangeCBChain(HWND hwnd, HWND hwndRemove, HWND hwndNext)";
            ht["WM_SETCURSOR"] = "BOOL Cls_OnSetCursor(HWND hwnd, HWND hwndCursor, UINT codeHitTest, UINT msg)";
            ht["WM_SYSCOMMAND"] = "void Cls_OnSysCommand(HWND hwnd, UINT cmd, int x, int y)";
            ht["WM_MDICREATE"] = "HWND Cls_MDICreate(HWND hwnd, const LPMDICREATESTRUCT lpmcs)";
            ht["WM_MDIDESTROY"] = "void Cls_MDIDestroy(HWND hwnd, HWND hwndDestroy)";
            ht["WM_MDIACTIVATE"] = "void Cls_MDIActivate(HWND hwnd, BOOL fActive, HWND hwndActivate, HWND hwndDeactivate)";
            ht["WM_MDIRESTORE"] = "void Cls_MDIRestore(HWND hwnd, HWND hwndRestore)";
            ht["WM_MDINEXT"] = "HWND Cls_MDINext(HWND hwnd, HWND hwndCur, BOOL fPrev)";
            ht["WM_MDIMAXIMIZE"] = "void Cls_MDIMaximize(HWND hwnd, HWND hwndMaximize)";
            ht["WM_MDITILE"] = "BOOL Cls_MDITile(HWND hwnd, UINT cmd)";
            ht["WM_MDICASCADE"] = "BOOL Cls_MDICascade(HWND hwnd, UINT cmd)";
            ht["WM_MDIICONARRANGE"] = "void Cls_MDIIconArrange(HWND hwnd)";
            ht["WM_MDIGETACTIVE"] = "HWND Cls_MDIGetActive(HWND hwnd)";
            ht["WM_MDISETMENU"] = "HMENU Cls_MDISetMenu(HWND hwnd, BOOL fRefresh, HMENU hmenuFrame, HMENU hmenuWindow)";
            ht["WM_CHILDACTIVATE"] = "void Cls_OnChildActivate(HWND hwnd)";
            ht["WM_INITDIALOG"] = "BOOL Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam)";
            ht["WM_NEXTDLGCTL"] = "HWND Cls_OnNextDlgCtl(HWND hwnd, HWND hwndSetFocus, BOOL fNext)";
            ht["WM_PARENTNOTIFY"] = "void Cls_OnParentNotify(HWND hwnd, UINT msg, HWND hwndChild, int idChild)";
            ht["WM_ENTERIDLE"] = "void Cls_OnEnterIdle(HWND hwnd, UINT source, HWND hwndSource)";
            ht["WM_GETDLGCODE"] = "UINT Cls_OnGetDlgCode(HWND hwnd, LPMSG lpmsg)";
            ht["WM_CTLCOLORMSGBOX"] = "HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type)";
            ht["WM_CTLCOLOREDIT"] = "HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type)";
            ht["WM_CTLCOLORLISTBOX"] = "HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type)";
            ht["WM_CTLCOLORBTN"] = "HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type)";
            ht["WM_CTLCOLORDLG"] = "HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type)";
            ht["WM_CTLCOLORSCROLLBAR"] = "HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type)";
            ht["WM_CTLCOLORSTATIC"] = "HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type)";
            ht["WM_SETFONT"] = "void Cls_OnSetFont(HWND hwndCtl, HFONT hfont, BOOL fRedraw)";
            ht["WM_GETFONT"] = "HFONT Cls_OnGetFont(HWND hwnd)";
            ht["WM_DRAWITEM"] = "void Cls_OnDrawItem(HWND hwnd, const DRAWITEMSTRUCT * lpDrawItem)";
            ht["WM_MEASUREITEM"] = "void Cls_OnMeasureItem(HWND hwnd, MEASUREITEMSTRUCT * lpMeasureItem)";
            ht["WM_DELETEITEM"] = "void Cls_OnDeleteItem(HWND hwnd, const DELETEITEMSTRUCT * lpDeleteItem)";
            ht["WM_COMPAREITEM"] = "int Cls_OnCompareItem(HWND hwnd, const COMPAREITEMSTRUCT * lpCompareItem)";
            ht["WM_VKEYTOITEM"] = "int Cls_OnVkeyToItem(HWND hwnd, UINT vk, HWND hwndListbox, int iCaret)";
            ht["WM_CHARTOITEM"] = "int Cls_OnCharToItem(HWND hwnd, UINT ch, HWND hwndListbox, int iCaret)";
            ht["WM_QUEUESYNC"] = "void Cls_OnQueueSync(HWND hwnd)";
            ht["WM_COMMNOTIFY"] = "void Cls_OnCommNotify(HWND hwnd, int cid, UINT flags)";
            ht["WM_DISPLAYCHANGE"] = "void Cls_OnDisplayChange(HWND hwnd, UINT bitsPerPixel, UINT cxScreen, UINT cyScreen)";
            ht["WM_DEVICECHANGE"] = "BOOL Cls_OnDeviceChange(HWND hwnd, UINT uEvent, DWORD dwEventData)";
            ht["WM_CONTEXTMENU"] = "void Cls_OnContextMenu(HWND hwnd, HWND hwndContext, UINT xPos, UINT yPos)";
            ht["WM_COPYDATA"] = "void Cls_OnContextMenu(HWND hwnd, HWND hwndContext, UINT xPos, UINT yPos)";
            ht["WM_HOTKEY"] = "void Cls_OnHotKey(HWND hwnd, int idHotKey, UINT fuModifiers, UINT vk)";
            #endregion
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            if (ht.ContainsKey(comboBox_Search.Text) == true)
            {
                Clipboard.SetDataObject(ht[comboBox_Search.Text]);
                MessageBox.Show("Copied!\nPlease press Ctrl + V", "Infomation");
            } 
            else
            {
                MessageBox.Show(comboBox_Search.Text + " message dosen't exist!", "Infomation");
            }
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}