import React, { useState } from 'react';

export const Comment = ({ comment, addReply }) => {
    const [showReplyForm, setShowReplyForm] = useState(false);
    const [replyText, setReplyText] = useState('');

    const handleReplySubmit = () => {
        addReply(comment.id, replyText);
        setReplyText('');
        setShowReplyForm(false);
    }


    return (
        <div className='comment'>
            <p><strong>{comment.author}</strong>: {comment.text}</p>
            <button onClick={() => setShowReplyForm(!showReplyForm)}>
                {showReplyForm ? 'Cancel' : 'Reply'}
            </button>
            {showReplyForm && (
                <div>
                    <input type="text" value={replyText} onChange={(e) => { setReplyText(e.target.value) }} />
                    <button onClick={handleReplySubmit}>Submit</button>
                </div>
            )}
            {comment.replies.length > 0 && (
                <div className='replies'>
                    {comment.replies.map(reply => (
                        <Comment key={reply.id} comment={reply} addReply={addReply} />
                    ))}

                </div>
            )}

        </div>
    );
};
