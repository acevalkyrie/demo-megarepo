#### Mary Sordyl
#### Final Project
#### COMS-170-HYB03: Fall 2021
#### Due: 12/21/21
#### Final Project - String Encryption
#============================================================
# Variable          Type        Purpose
#============================================================
# UNKNOWNERR        string      stores error messages for unforeseen input errors
# strSelect         string      stores user selection of whether to encrypt, decrypt, or exit program
# Parallel1         list        stores the plain alphabet parallel list
#### aka Decrypt (StoreEncrypt function), In / Out (RunEncrypt function)
####  ----  ----  ----  ----
# Parallel2         list        stores the corresponding encrypted alphabet parallel list
#### AKA Encrypt (StoreEncrypt function), Out / In (RunEncrypt function)
####  ----  ----  ----  ----
# strMessage        string      stores the user's message to be encrypted/decrypted
#### AKA Message (RunEncrypt function)
####  ----  ----  ----  ----
# strOutput         string      stores the result of the RunEncrypt function once the message has been modified
#### AKA Coded (RunEncrypt function)
####  ----  ----  ----  ----
# iIndex            integer     stores the index of a character in a list for use in replacing it with the corresponding index of the parallel list

# set error messages
global UNKNOWNERR
UNKNOWNERR = "\n    An unknown error occurred. Make sure you aren't using\n    any incompatible special symbols."
# the only error I can imagine breaking this would be a unicode error, but I decided to leave it general to cover all bases

# define main function
def main():
    # initialize strSelect to begin menu loop
    strSelect = "Y"
    # keep the parallel alphabet lists in a separate function if only to make it Slightly harder to Crack The Code from looking at the program
    Parallel1, Parallel2 = StoreEncrypt()
    while strSelect != "X":    # begin looping menu
        print("""|        PHRASE ENCRYPTION ASSISTANT
+-------------------------------------------

          |E| - | Encrypt Phrase |
          |D| - | Decrypt Phrase |
          |X| - |      Exit      |
""")
        
        # exception handling for potential unicode errors or unforeseen errors
        try:
            # get user's choice to encrypt, decrypt, or exit
            strSelect = input("        Enter your menu selection: ").upper()
        except:
            print(UNKNOWNERR)
            
        # run if they chose to encrypt
        if strSelect == "E":
            print("""
                        ENCRYPTION ASSISTANT
                    ----------------------------
""")
            # exception handling for potential unicode errors or unforeseen errors
            try:
                #get user's message to be encrypted
                strMessage = input("            Enter the phrase you would like to encrypt:\n            ").upper()
                # call RunEncrypt() to modify their message
                strOutput = RunEncrypt(strMessage, Parallel1, Parallel2)    # put Parallel1 before Parallel2 to encrypt message
                # display the encrypted message
                print("""
                    Your encrypted message is:
            """ + strOutput)
            except:
                print(UNKNOWNERR)
            input("\n                   Press enter to return to menu.")

        # run if they chose to decrypt
        elif strSelect == "D":
            print("""
                        DECRYPTION ASSISTANT
                    ----------------------------
""")
            # exception handling for potential unicode errors or unforeseen errors
            try:
                # get user's message to be decrypted
                strMessage = input("            Enter the phrase you would like to decrypt:\n            ").upper()
                # call RunEncrypt() to modify their message
                strOutput = RunEncrypt(strMessage, Parallel2, Parallel1)    # put Parallel2 before Parallel1 to decrypt message
                # display the decrypted message
                print("""
                    Your decrypted message is:
            """ + strOutput)
            except:
                print(UNKNOWNERR)
            input("\n                   Press enter to return to menu.")

        # formatting additions
        if strSelect != "X":
            print("\n+-------------------------------------------------------------------")

# define StoreEncrypt function
def StoreEncrypt():
    # initialize parallel lists to be used for encrypting and decrypting
    Decrypt = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", ".", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"]
    Encrypt = ["G", "2", "M", "T", "C", ".", "O", "R", "Z", "J", "6", "X", "Q", "8", "L", "A", "E", "W", "3", "V", "9", "4", "D", "K", "7", "0", "F", "5", "B", "S", "I", "1", "N", "U", "H", "Y", "P"]
    return Decrypt, Encrypt

# define RunEncrypt function
def RunEncrypt(Message, In, Out):    # placement of Parallel1 and Parallel2 determine if it encrypts or decrypts
    # initialize Coded to copy the modified message
    Coded = ""
    # use for loop to copy each character's corresponding character over from the other parallel list
    for i in Message:
        # use if statement to avoid errors with characters not in either alphabet
        if i in In:
            iIndex = In.index(i)    # find the index of input character for use in pulling the output character from the parallel list
            Coded += Out[iIndex]    # concatenate the corresponding encrypted/decrypted letter
        else:
            Coded += i
    return Coded    # return the modified message to strOutput

main()

# Final program output
#### ===== RESTART: C:/Users/mmsor/Documents/Classes/Fall 2021/COMS-170/FinalProject/00 Template.py =====
#### |        PHRASE ENCRYPTION ASSISTANT
#### +-------------------------------------------
####
####           |E| - | Encrypt Phrase |
####           |D| - | Decrypt Phrase |
####           |X| - |      Exit      |
####
####         Enter your menu selection: e
####
####                         ENCRYPTION ASSISTANT
####                     ----------------------------
####
####             Enter the phrase you would like to encrypt:
####             I LOVE COMPUTERS
####
####                     Your encrypted message is:
####             Z XL4C MLQA9VCW3
####
####                    Press enter to return to menu.
####
#### +-------------------------------------------------------------------
#### |        PHRASE ENCRYPTION ASSISTANT
#### +-------------------------------------------
####
####           |E| - | Encrypt Phrase |
####           |D| - | Decrypt Phrase |
####           |X| - |      Exit      |
####
####         Enter your menu selection: d
####
####                         DECRYPTION ASSISTANT
####                     ----------------------------
####
####             Enter the phrase you would like to decrypt:
####             z xl4c mlqa9vcw3
####
####                     Your decrypted message is:
####             I LOVE COMPUTERS
####
####                    Press enter to return to menu.
####
#### +-------------------------------------------------------------------
#### |        PHRASE ENCRYPTION ASSISTANT
#### +-------------------------------------------
####
####           |E| - | Encrypt Phrase |
####           |D| - | Decrypt Phrase |
####           |X| - |      Exit      |
####
####         Enter your menu selection: E
####
####                         ENCRYPTION ASSISTANT
####                     ----------------------------
####
####             Enter the phrase you would like to encrypt:
####             I may or may not have finished the vast majority of this program in 1.5 hours on December 1st and instantly panicked I must have misunderstood something to finish it so fast
####
####                     Your encrypted message is:
####             Z QG7 LW QG7 8LV RG4C .Z8Z3RCT VRC 4G3V QGJLWZV7 L. VRZ3 AWLOWGQ Z8 5F1 RL9W3 L8 TCMCQ2CW 53V G8T Z83VG8VX7 AG8ZM6CT Z Q93V RG4C QZ398TCW3VLLT 3LQCVRZ8O VL .Z8Z3R ZV 3L .G3V
####
####                    Press enter to return to menu.
####
#### +-------------------------------------------------------------------
#### |        PHRASE ENCRYPTION ASSISTANT
#### +-------------------------------------------
####
####           |E| - | Encrypt Phrase |
####           |D| - | Decrypt Phrase |
####           |X| - |      Exit      |
####
####         Enter your menu selection: x
#### >>> 
