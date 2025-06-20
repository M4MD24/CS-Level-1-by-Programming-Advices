# C# Level 1

**Important Note for Console App Projects:** To Run Any File Rename Main Method from "main" to "Main", Because can't run 2 Static "Main" Methods in One Project

1. [Concepts](src/_1_concepts)
    1. Library, Framework and Platform
    2. .NET
        1. What is .NET?
        2. .NET Core vs .NET Framework?
        3. What can we do with .NET?
        4. What to Learn .NET Framework or .NET Core?
        5. Compilation in .NET
    3. .NET Framework
        1. .NET Framework Architecture
        2. What is CLR?
        3. CLR Main Components
        4. Common Type System (CTS)
        5. Common Language Specification (CLS)
        6. Garbage Collector (GC)
        7. Just In Time Compilation (JIT)
        8. Assemblies & Metadata (Manifest)
        9. CLR Functions
        10. Managed vs Unmanaged Code
        11. CLR Structure
        12. .NET Framework Class Library
    4. What is C#? and Why to Learn It?
    5. [Syntax](src/_1_concepts/_1_5_syntax)
        1. [Console App](src/_1_concepts/_1_5_syntax/_1_5_1_console_app)
            1. [Output](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_1_output)
                1. WriteLine
                2. Write
                3. Formatted String
                4. Escape Characters
            2. [Comments](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_2_comments)
            3. [Variables](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_3_variables)
                1. Variables
                2. Rules for Naming Variables
                3. Implicitly Typed Variables
            4. [Data Types](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_4_data_types)
                1. Data Types
                2. Predefined Data Types
                3. Literals
                4. Default Values
                5. Enums
                6. Nullable Types
                7. Anonymous Types
                8. Structures
                9. Dynamic Type
            5. [Date & Time](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_5_date_and_time)
                1. Set
                2. Get
                3. Ticks
                4. Static Fields
                5. TimeSpan
                6. Operators
                7. Convert String to DateTime
            6. [Strings](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_6_strings)
                1. String Methods
                2. String Interpolation
            7. [Casting Types](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_7_casting_types)
                1. Implicit Casting
                2. Explicit Casting
                3. Type Conversion Methods
                4. Casting Enums
            8. [User Input](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_8_user_input)
                1. ReadLine
                2. Input Number
            9. [Operators](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_9_operators)
                1. Assignment Operators
                2. Arithmetic Operators
                3. Relational Operators
                4. Logical Operators
                5. Unary Operators
                6. Ternary Operator
                7. Bitwise and Bit Shift Operators
            10. [Control Flow](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_10_control_flow)
                1. If Condition
                2. Switch Statement
                3. Ternary Operator
                4. For Loop
                5. While Loop
                6. Do While Loop
                7. Break Statement
                8. Continue Statement
            11. [Arrays](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_11_arrays)
                1. Arrays Are Bound
                2. Array Declaration
                3. Array Initialization
                4. Access Array Elements
                5. Two Dimensional Array
                6. For Each Loop
            12. [Array Operations using System.Linq](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_12_array_operators_with_system_dot_linq)
            13. [Math](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_13_math)
            14. [Methods](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_14_methods)
                1. Create Methods
                2. Method Parameter
                3. Default Parameter Value
                4. Return Value
                5. Named Arguments
                6. Method Overloading
            15. [Exceptions](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_15_exceptions)
            16. [Random Method](src/_1_concepts/_1_5_syntax/_1_5_1_console_app/_1_5_1_16_random_method)
        2. Windows Forms
            1. [Concepts](WindowsFormsConcepts/WindowsFormsConcepts.cs)
                1. Web vs Desktop Applications
                2. [Introduction About Controls](WindowsFormsConcepts/IntroductionAboutControls)
                    1. Introduction About Controls
                    2. Designer Toolbox & Properties & Events
                    3. [TextBoxes & Button & Form & Label](WindowsFormsConcepts/IntroductionAboutControls/TextBoxesAndButtonsAndFormsAndLabels.cs)
                    4. [Flat Appearance](WindowsFormsConcepts/IntroductionAboutControls/FlatAppearance.cs)
                    5. TabIndex & TabStop
                    6. [New Forms](WindowsFormsConcepts/IntroductionAboutControls/NewForms)
                    7. [MessageBox](WindowsFormsConcepts/IntroductionAboutControls/MessageBoxExample.cs)
                    8. [CheckBox & RadioButton & GroupBox & Tag](WindowsFormsConcepts/IntroductionAboutControls/CheckBoxAndRadioButtonAndGroupBoxAndTag.cs)
                3. [TextBox](WindowsFormsConcepts/TextBoxExample.cs)
                4. [PictureBox](WindowsFormsConcepts/PictureBox)
                5. [Drawing](WindowsFormsConcepts/Drawing.cs)
                6. [MaskedTextBox](WindowsFormsConcepts/MaskedTextBoxExample.cs)
                7. [ComboBox](WindowsFormsConcepts/ComboBoxExample.cs)
                8. [LinkLabel](WindowsFormsConcepts/LinkLabelExample.cs)
                9. [CheckedListBox](WindowsFormsConcepts/CheckedListBoxExample.cs)
                10. [DateTime Controls](WindowsFormsConcepts/DateTimeControls)
                    1. [DateTimePicker](WindowsFormsConcepts/DateTimeControls/DateTimePickerExample.cs)
                    2. [Month Calendar](WindowsFormsConcepts/DateTimeControls/MonthCalendarExample.cs)
                11. [Timer](WindowsFormsConcepts/TimerExample.cs)
                12. [NotifyIcon](WindowsFormsConcepts/NotifyIconExample.cs)
                13. [TreeView and ImageList](WindowsFormsConcepts/TreeViewAndImageList/TreeViewAndImageList.cs)
                14. [ProgressBar](WindowsFormsConcepts/ProgressBarExample.cs)
                15. [ListView](WindowsFormsConcepts/ListView)
                16. [ErrorProvider](WindowsFormsConcepts/ErrorProviderExample.cs)
                17. [TrackBar](WindowsFormsConcepts/TrackBarExample.cs)
                18. [NumericUpDown](WindowsFormsConcepts/NumericUpDownExample.cs)
                19. [Containers](WindowsFormsConcepts/Containers)
                    1. [TabControl](WindowsFormsConcepts/Containers/TabControlExample.cs)
                    2. [Panel](WindowsFormsConcepts/Containers/PanelExample.cs)
                    3. GroupBox vs Panel
                20. [Dialogs](WindowsFormsConcepts/Dialogs/DialogsExample.cs)
                    1. ColorDialog
                    2. FontDialog
                    3. SaveFileDialog
                    4. OpenFileDialog
                    5. FolderBrowserDialog
                21. [Multiple Documents Interface (MDI) Container](WindowsFormsConcepts/MultipleDocumentsInterfaceContainer)
                22. ~~Menus~~
            2. [Projects](WindowsFormsProjects)
                1. [Pizza Order System](WindowsFormsProjects/PizzaOrderSystem)
                2. [Display Number](WindowsFormsProjects/DisplayNumber)
                3. [Tic-Tac-Toe](WindowsFormsProjects/TicTacToe)
                4. [Display Arrow Directions](WindowsFormsProjects/DisplayArrowDirections)