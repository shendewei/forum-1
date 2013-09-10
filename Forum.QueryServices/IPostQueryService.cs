using System.Collections.Generic;
using Forum.QueryServices.DTOs;

namespace Forum.QueryServices
{
    /// <summary>���Ӳ�ѯ����
    /// </summary>
    public interface IPostQueryService
    {
        /// <summary>��ѯ�����б�
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        IEnumerable<Post> QueryPosts(PostQueryOption option);
    }
}