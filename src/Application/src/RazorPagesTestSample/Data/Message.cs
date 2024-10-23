using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        /// <value>
        /// The text of the message, which is required and must be a string with a maximum length of 200 characters.
        /// </value>
        /// <remarks>
        /// An error message will be displayed if the text exceeds 200 characters: "There's a 200 character limit on messages. Please shorten your message."
        /// </remarks>
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200, ErrorMessage = "There's a 200 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
