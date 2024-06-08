import React, { useState } from 'react';
import { commentsData } from '../assets/data';
import { Comment } from './Comment'
export const CommentList = () => {
    const [comments, setComments] = useState(commentsData);
    const addReply = (commentId, text) => {
        const newComment = {
            id: Date.now(),
            text,
            author: 'current User',
            replies: []
        };

        const addReplyToComment = (comments, commentId) => {
            return comments.map(comment => {
                if (comment.id == commentId) {
                    return { ...comment, replies: [...comment.replies, newComment] };
                }
                else if (comment.replies.length > 0) {
                    return { ...comment, replies: addReplyToComment(comment.replies, commentId) };
                }
                return comment;
            });
        };
        setComments(prevComments => addReplyToComment(prevComments, commentId));
    };

    return (
        <div className='comment-list'>
            {comments.map(comment => {
                return <Comment key={comment.id} comment={comment} addReply={addReply} />
            })}

        </div>
    );
};
