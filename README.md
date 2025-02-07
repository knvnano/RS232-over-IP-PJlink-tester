### **README.md - RS over IP Projector Control**

# **RS over IP Projector Control (WinForms Application)**

## **Overview**
This Windows Forms application allows users to send **RS232 HEX commands over IP** to control a projector. The program supports both **direct RS232 commands** and **PJLink protocol** over a network connection.

## **Features**
✅ **Send RS232 HEX Commands over IP**  
✅ **Supports PJLink Protocol** for network-based projector control  
✅ **Real-time command conversion** from ASCII (PJLink) to HEX format  
✅ **Displays server responses** in both HEX and human-readable text format  
✅ **Progress bar animation** to indicate command processing and prevent UI freezing  
✅ **Customizable IP address and port input**  

## **User Interface Components**
- `richTextBoxHexCommand` – Input box for HEX RS232 commands  
- `richTextBoxASCII` – Input box for PJLink ASCII commands (auto-converts to HEX)  
- `textBoxIpAdress` – IP address input for the projector  
- `textBoxPortNumber` – Port number input  
- `buttonSendRsOverIP` – Button to send the command  
- `richTextBoxStatus` – Displays sent commands, responses, and status messages  
- `checkBoxHumanAnswer` – Converts server responses to human-readable text  
- `progressBarWaitResponce` – Progress animation during network communication  

## **How It Works**
1. Enter a **HEX command** in `richTextBoxHexCommand` **or** type a **PJLink command** in `richTextBoxASCII` (auto-converted to HEX).  
2. Specify the **IP address** and **port number** of the projector.  
3. Click **Send** (`buttonSendRsOverIP`) to transmit the command.  
4. The program **awaits a response** from the projector and displays it in `richTextBoxStatus`.  
5. If `checkBoxHumanAnswer` is checked, the response is **displayed as text** instead of HEX.  

## **Example Usage**
- **Sending a PJLink power status request**  
  Input in `richTextBoxASCII`:  
  ```
  %1POWR ?
  ```
  Auto-converted to HEX in `richTextBoxHexCommand`:  
  ```
  25 31 50 4F 57 52 20 3F 0D
  ```
  Expected response:  
  ```
  POWR=1  (Projector is ON)
  ```

- **Sending an RS232 HEX command (Example: Turn off projector)**
  ```
  02 3F 50 57 52 0D
  ```

## **Installation & Requirements**
- **Windows OS** (Windows 10/11 recommended)  
- **.NET Framework 4.7.2 or later**  
- **Network-connected projector supporting RS over IP or PJLink**  

## **Future Improvements**
- Implement **password authentication** for PJLink  
- Add **TCP timeout handling** for better error management  
- Improve UI with additional **projector status indicators**  

---

Feel free to **fork**, **contribute**, and **report issues** on GitHub! 🚀

