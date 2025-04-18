##Project Name
#CAN Frame Parser 

#🧠 Short Description
This application connects to a serial port, parses incoming CAN frames (11-bit and 29-bit), and displays them in a GUI. It also integrates with an ABB robot, sending object position data after processing, enabling pick-and-place operations.

#✨ Main Features
Connect to and manage serial port settings saved in a SQLite database.

Parse and visualize standard (11-bit) and extended (29-bit) CAN frames.

Store and manage parsed CAN frame data in a list and grid view.

Expose data through Serial Port

#Technologies Used
C#

Windows Forms (WinForms)

SQLite (for serial port settings)
